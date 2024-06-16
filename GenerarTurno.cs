using Clinica_SePrice.Datos;
using MySql.Data.MySqlClient;
using System;
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
            dateTimePicker.ValueChanged += new EventHandler(dateTimePicker_ValueChanged);
        }

        private void comboBoxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfoEspecialidad.Text = "Ha seleccionado la especialidad: " + comboBoxEspecialidad.Text;
        }

        private void comboBoxMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfoMedico.Text = "Ha seleccionado el médico/a: " + comboBoxMedico.Text;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            TimeSpan startTime = new TimeSpan(9, 0, 0);
            TimeSpan endTime = new TimeSpan(17, 0, 0);
            TimeSpan interval = new TimeSpan(0, 30, 0);

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
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una hora para el turno.");
                return;
            }

            string especialidad = comboBoxEspecialidad.Text;
            string medico = comboBoxMedico.Text;
            DateTime selectedDate = dateTimePicker.Value.Date;
            string selectedTime = listBox.SelectedItem.ToString();
            DateTime selectedDateTime = DateTime.Parse(selectedDate.ToShortDateString() + " " + selectedTime);

            
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
