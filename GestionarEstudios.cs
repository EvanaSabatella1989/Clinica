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
    public partial class frmGestionarEstudios : Form
    {
        public frmGestionarEstudios()
        {
            InitializeComponent();
        }

        private void btnVolverGestionarEstudios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarEstudio_Click(object sender, EventArgs e)
        {
            frmAgregarEstudio agregarEstudioForm = new frmAgregarEstudio(dgvEstudios);
            agregarEstudioForm.ShowDialog();
        }
    }
}
