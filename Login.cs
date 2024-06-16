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
            dt = dato.Login(txtUsuario.Text, txtContrasena.Text);

            if (dt.Rows.Count > 0)
            {
                string nUsuario = dt.Rows[0][1] != null ? dt.Rows[0][1].ToString() : "N/A";
                Form menu = new frmMenu(nUsuario);
                menu.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("El usuario y/o contaseña incorrecto ");


            }

        }
    }
}
