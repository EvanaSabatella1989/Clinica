using Clinica_SePrice.Datos;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Clinica_SePrice
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            }
            else
            {
                MessageBox.Show("El usuario y/o contaseña incorrecto ");


            }

        }
    }
}
