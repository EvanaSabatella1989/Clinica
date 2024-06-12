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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form seccion = new Seccion();
            seccion.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionDeInsumos_Click(object sender, EventArgs e)
        {
            frmGestionarInsumos gestionarInsumosForm = new frmGestionarInsumos();
            gestionarInsumosForm.Show();

        }
    }
}
