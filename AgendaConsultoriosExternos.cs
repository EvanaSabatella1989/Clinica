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
    public partial class frmAgendaConsultoriosExternos : Form
    {
        public frmAgendaConsultoriosExternos()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Form generarTurno = new GenerarTurno();
            generarTurno.StartPosition = FormStartPosition.CenterScreen;
            generarTurno.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
