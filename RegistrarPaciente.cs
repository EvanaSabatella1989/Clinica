using Clinica_SePrice.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Clinica_SePrice
{
    public partial class frmRegistrarPaciente : Form
    {
        public frmRegistrarPaciente()
        {
            InitializeComponent();
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            string nombreIngresado = txtNombrePaciente.Text;
            string apellidoIngresado = txtApellidoPaciente.Text;
            string dniIngresado = txtDniPaciente.Text;

            if (nombreIngresado == "" || apellidoIngresado == "" || dniIngresado == "")
            {
                MessageBox.Show("Por favor, complete todos los campos", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Verificar si el DNI ya está registrado
                if (DniExisteEnBaseDeDatos(dniIngresado))
                {
                    MessageBox.Show("Ya existe un paciente registrado con ese DNI", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Paciente paciente = new Paciente();
                paciente.Nombre = txtNombrePaciente.Text;
                paciente.Apellido = txtApellidoPaciente.Text;
                paciente.Dni = Convert.ToInt32(txtDniPaciente.Text);
                paciente.FechaNac = dateTimePicker1.Value;

                string respuesta = Datos.Pacientes.NuevoPaciente(paciente);
                bool esNumero = int.TryParse(respuesta, out int codigo);

                if (esNumero)
                {
                    if (codigo == 0)
                    {
                        MessageBox.Show("El paciente ya se encuentra registrado", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Se almacenó con éxito el paciente Nro {respuesta}", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Error al intentar guardar el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVolverRegistrarPaciente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool DniExisteEnBaseDeDatos(string dni)
        {
            bool existe = false;

            try
            {
                Conexion conexion = Conexion.getInstancia();
                using (var conn = conexion.CrearConexion())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM persona WHERE dni = @dni";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        existe = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el DNI: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return existe;
        }
    }
}
