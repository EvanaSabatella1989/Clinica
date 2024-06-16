using Clinica_SePrice.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace Clinica_SePrice
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            DataTable dt = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();
            //dt = dato.Login(txtUsuario.Text, txtContrasena.Text);

            bool loginExitoso = true; 

            if (loginExitoso)
            {
                MessageBox.Show("Ingreso exitoso");

                frmMenu menu = new frmMenu();
                menu.StartPosition = FormStartPosition.CenterScreen;
                menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña es incorrecto");
            }
        }
    }
}
