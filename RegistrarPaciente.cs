using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                String respuesta;
                Paciente paciente = new Paciente();
                paciente.Nombre = txtNombrePaciente.Text;
                paciente.Apellido = txtApellidoPaciente.Text;
                paciente.Dni = Convert.ToInt32(txtDniPaciente.Text);
                paciente.FechaNac = Convert.ToDateTime(dateTimePicker1.Text);

              
                respuesta = Datos.Pacientes.NuevoPaciente(paciente);
                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 0)
                    {
                        MessageBox.Show(" EL PACIENTE YA SE ENCUENTRA REGISTRADO", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se almaceno con exito el paciente Nro " + respuesta, "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.Close();
                        //Form pagar = new Pagar();
                        //pagar.ShowDialog();
                    }
                }
                /* if (dniIngresado == "12345678")
                 {
                     MessageBox.Show("Ya existe un paciente registrado con ese DNI", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 else
                 {
                     MessageBox.Show("Registro exitoso", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }*/
            }


        }

        private void btnVolverRegistrarPaciente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
