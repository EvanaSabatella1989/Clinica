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
    public partial class frmSeccion : Form
    {
        public frmSeccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form agenda = new Agenda();
            agenda.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEstudiosClinicos_Click(object sender, EventArgs e)
        {
            Form agendarTurnoEstudios = new frmAgendarTurnoEstudios();
            agendarTurnoEstudios.StartPosition = FormStartPosition.CenterScreen;
            agendarTurnoEstudios.Show();
            this.Close();
        }
    }
}
