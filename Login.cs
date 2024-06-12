using Clinica_SePrice.Datos;
using System.Data;

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
            //dt = dato.Login(txtUsuario.Text, txtContrasena.Text);

           // if (dt.Rows.Count > 0)
           // {
                MessageBox.Show("Ingreso exitoso");
                Form menu = new Menu();
                menu.Show();
                //this.Hide();
                this.WindowState = FormWindowState.Minimized;
                //ShowInTaskbar = true;


           // }
           // else
          //  {
          //      MessageBox.Show("El usuario y/o contaseña incorrecto ");


          //  }
        }
    }
}
