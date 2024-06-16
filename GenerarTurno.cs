using Clinica_SePrice.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinica_SePrice
{
    public partial class GenerarTurno : Form
    {
        private readonly Conexion conexion = Conexion.getInstancia();
        private readonly Dictionary<string, string> pacientesRegistrados = new Dictionary<string, string>();

        public GenerarTurno()
        {
            InitializeComponent();
            InitializeDateTimePicker();
            InitializeComboBoxes();
            dateTimePicker.ValueChanged += new EventHandler(dateTimePicker_ValueChanged);
        }

        private void InitializeDateTimePicker()
        {
            dateTimePicker.MinDate = DateTime.Today;
            dateTimePicker.MaxDate = DateTime.Today.AddMonths(6);
            dateTimePicker.Value = DateTime.Today;
        }

        private void InitializeComboBoxes()
        {
            comboBoxEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMedico.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxEspecialidad.Items.AddRange(new string[] { "Cardiología", "Dermatología", "Pediatría", "Neurología" });
            comboBoxMedico.Items.AddRange(new string[] { "Dr. Pérez", "Dr. López", "Dra. García", "Dr. Fernández" });

            if (comboBoxEspecialidad.Items.Count > 0)
                comboBoxEspecialidad.SelectedIndex = 0;

            if (comboBoxMedico.Items.Count > 0)
                comboBoxMedico.SelectedIndex = 0;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            TimeSpan startTime = new TimeSpan(9, 0, 0); // 9:00 AM
            TimeSpan endTime = new TimeSpan(17, 0, 0); // 5:00 PM
            TimeSpan interval = new TimeSpan(0, 30, 0); // Intervalo de 30 minutos

            DateTime selectedDate = dateTimePicker.Value.Date;

            if (selectedDate == DateTime.Today)
            {
                TimeSpan now = DateTime.Now.TimeOfDay;
                startTime = now > startTime ? now : startTime;
            }

            for (TimeSpan time = startTime; time < endTime; time += interval)
            {
                listBox.Items.Add(time.ToString(@"hh\:mm"));
            }
        }

        private void btnVerificarDni_Click(object sender, EventArgs e)
        {
            string dni = textBoxDni.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.");
                return;
            }

            if (DniExisteEnBaseDeDatos(dni))
            {
                MessageBox.Show("DNI verificado. Puede proceder a reservar un turno.");
                dateTimePicker.Visible = true;
                listBox.Visible = true;
                btnConfirmaTurno.Visible = true;
            }
            else
            {
                MessageBox.Show("El DNI no está registrado. Debe registrarse primero.");
                Form registrarPaciente = new frmRegistrarPaciente();
                registrarPaciente.StartPosition = FormStartPosition.CenterScreen;
                registrarPaciente.ShowDialog();
            }
        }

        private bool DniExisteEnBaseDeDatos(string dni)
        {
            bool existe = false;

            try
            {
                using (MySqlConnection conn = conexion.CrearConexion())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM persona AS p JOIN paciente AS pa ON p.idPersona = pa.idPersona WHERE p.dni = @dni";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        existe = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el DNI en la base de datos: " + ex.Message);
            }

            return existe;
        }

        private void btnConfirmaTurno_Click(object sender, EventArgs e)
        {
            string dni = textBoxDni.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DniExisteEnBaseDeDatos(dni))
            {
                MessageBox.Show("El DNI ingresado no está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una hora para el turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxEspecialidad.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxMedico.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string especialidad = comboBoxEspecialidad.SelectedItem.ToString();
            string medico = comboBoxMedico.SelectedItem.ToString();
            DateTime selectedDate = dateTimePicker.Value.Date;
            string selectedTime = listBox.SelectedItem.ToString();
            DateTime selectedDateTime = DateTime.Parse(selectedDate.ToShortDateString() + " " + selectedTime);

            int idPaciente = ObtenerIdPacientePorDni(dni);

            MessageBox.Show("Turno reservado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int ObtenerIdPacientePorDni(string dni)
        {
            int idPaciente = 0;

            try
            {
                using (MySqlConnection conn = conexion.CrearConexion())
                {
                    conn.Open();
                    string query = "SELECT idPaciente FROM paciente AS pa JOIN persona AS p ON pa.idPersona = p.idPersona WHERE p.dni = @dni";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            idPaciente = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del paciente: " + ex.Message);
            }

            return idPaciente;
        }
    }
}
