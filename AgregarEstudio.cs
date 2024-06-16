using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Clinica_SePrice.Datos;

namespace Clinica_SePrice
{
    public partial class frmAgregarEstudio : Form
    {
        private DataGridView dgvEstudios;
        private readonly Conexion conexion = Conexion.getInstancia();

        public frmAgregarEstudio(DataGridView dgvEstudios)
        {
            InitializeComponent();
            this.dgvEstudios = dgvEstudios;
            cmbTipoEstudio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregarEstudio_Click(object sender, EventArgs e)
        {
            int idEstudio;
            if (!int.TryParse(txtIdEstudio.Text, out idEstudio))
            {
                MessageBox.Show("El ID del estudio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbTipoEstudio.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de estudio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int dniPaciente;
            if (!int.TryParse(txtDniPaciente.Text, out dniPaciente))
            {
                MessageBox.Show("El DNI del paciente debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tipoEstudio = cmbTipoEstudio.SelectedItem.ToString();
            DateTime fechaEstudio = dtpFechaEstudio.Value;

            var paciente = ObtenerPacientePorDni(dniPaciente.ToString());
            if (paciente == null)
            {
                MessageBox.Show("El DNI ingresado no está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvEstudios);
            fila.Cells[0].Value = idEstudio;
            fila.Cells[1].Value = tipoEstudio;
            fila.Cells[2].Value = dniPaciente;
            fila.Cells[3].Value = paciente.Nombre;
            fila.Cells[4].Value = paciente.Apellido;
            fila.Cells[5].Value = fechaEstudio.ToShortDateString();
            dgvEstudios.Rows.Add(fila);

            this.Close();
        }

        private Paciente ObtenerPacientePorDni(string dni)
        {
            Paciente paciente = null;

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
                                paciente = new Paciente
                                {
                                    Nombre = reader.GetString("nombre"),
                                    Apellido = reader.GetString("apellido")
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos del paciente: " + ex.Message);
            }

            return paciente;
        }

        private class Paciente
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
        }
    }
}
