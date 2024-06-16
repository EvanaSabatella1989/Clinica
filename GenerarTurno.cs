using Clinica_SePrice.Datos;

using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Clinica_SePrice
{
    public partial class frmGenerarTurno : Form
    {
        public frmAgendaConsultoriosExternos FormAgendaConsultoriosExternos { get; set; }

        private readonly Conexion conexion = Conexion.getInstancia();

        public frmGenerarTurno()
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

            if (comboBoxEspecialidad.Items.Count > 0)
                comboBoxEspecialidad.SelectedIndex = 0;

            if (comboBoxMedico.Items.Count > 0)
                comboBoxMedico.SelectedIndex = 0;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            TimeSpan interval = new TimeSpan(0, 30, 0); // Intervalo de 30 minutos

            DateTime selectedDate = dateTimePicker.Value.Date;
            DateTime today = DateTime.Today;

            TimeSpan now = DateTime.Now.TimeOfDay;
            TimeSpan startTime = new TimeSpan(9, 0, 0); // Inicio de horarios a las 9:00 AM
            TimeSpan endTime = new TimeSpan(16, 30, 0); // Fin de horarios a las 4:30 PM

            if (selectedDate == today && now < endTime)
            {
                startTime = now > startTime ? now : startTime;

                int minutesToAdd = interval.Minutes - (now.Minutes % interval.Minutes);
                startTime = now.Add(TimeSpan.FromMinutes(minutesToAdd));
            }

            if (selectedDate == today)
            {
                endTime = new TimeSpan(17, 0, 0);
            }

            for (TimeSpan time = startTime; time <= endTime; time += interval)
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

            string nombre;
            string apellido;
            ObtenerNombreYApellidoPorDni(dni, out nombre, out apellido);

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

            Datos.Turnos.CrearTurno( )

            string especialidad = comboBoxEspecialidad.SelectedItem.ToString();
            string medico = comboBoxMedico.SelectedItem.ToString();
            DateTime selectedDate = dateTimePicker.Value.Date;
            string selectedTime = listBox.SelectedItem.ToString();
            DateTime selectedDateTime = DateTime.Parse(selectedDate.ToShortDateString() + " " + selectedTime);

            if (selectedDateTime < DateTime.Now)
            {
                MessageBox.Show("No se puede reservar un turno en una fecha u hora anterior a la actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBox.Items.Clear(); 
                return;
            }

            if (selectedDate == DateTime.Today && DateTime.Now.TimeOfDay >= new TimeSpan(17, 0, 0))
            {
                MessageBox.Show("No hay turnos disponibles para hoy después de las 17:00 horas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox.Items.Clear(); 
                return;
            }

            frmAgendaConsultoriosExternos agendaForm = Application.OpenForms.OfType<frmAgendaConsultoriosExternos>().FirstOrDefault();
            if (agendaForm != null)
            {
                agendaForm.AgregarTurno(selectedDate, selectedTime, dni, nombre, apellido, medico, especialidad);
            }

            MessageBox.Show("Turno reservado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }



        private void ObtenerNombreYApellidoPorDni(string dni, out string nombre, out string apellido)
        {
            nombre = string.Empty;
            apellido = string.Empty;

            try
            {
                using (MySqlConnection conn = conexion.CrearConexion())
                {
                    conn.Open();
                    string query = "SELECT nombre, apellido FROM persona WHERE dni = @dni";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nombre = reader["nombre"].ToString();
                                apellido = reader["apellido"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener nombre y apellido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void ObtenerIdPorDni(string dni, int idPaciente)
        {
            //idPaciente = int;


            try
            {
                using (MySqlConnection conn = conexion.CrearConexion())
                {
                    conn.Open();
                    string query = "SELECT idPaciente FROM persona INNER JOIN paciente WHERE persona.idPersona= paciente.idPersona and persona.dni = @dni";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idPaciente = int.Parse(reader["idPaciente"].ToString());

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener idPaciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ObtenerMedicoPorDni(string dni, int idPaciente)
        {
            //idPaciente = int;


            try
            {
                using (MySqlConnection conn = conexion.CrearConexion())
                {
                    conn.Open();
                    string query = "SELECT idMedico FROM persona INNER JOIN medico WHERE persona.idPersona= paciente.idMedico and persona.dni = @dni";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idPaciente = int.Parse(reader["idPaciente"].ToString());

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener idPaciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
