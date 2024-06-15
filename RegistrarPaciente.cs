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
            string apellidoIngresado = txtNombrePaciente.Text;
            string dniIngresado = txtDniPaciente.Text;

            if (nombreIngresado == "" || apellidoIngresado == "" || dniIngresado == "")
            {
                MessageBox.Show("Por favor, complete todos los campos", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dniIngresado == "12345678")
                {
                    MessageBox.Show("Ya existe un paciente registrado con ese DNI", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Registro exitoso", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void btnVolverRegistrarPaciente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
