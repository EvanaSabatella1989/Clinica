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
    public partial class frmMenu : Form
    {
        private frmGestionarInsumos gestionarInsumosForm;

        public frmMenu()
        {
            InitializeComponent();
            gestionarInsumosForm = new frmGestionarInsumos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form seccion = new frmSeccion();
            seccion.StartPosition = FormStartPosition.CenterScreen;
            seccion.Show();
            this.Hide();
        }

        private void btnGestionDeInsumos_Click(object sender, EventArgs e)
        {
            Form GestionDeInsumos = new frmGestionarInsumos();
            GestionDeInsumos.StartPosition = FormStartPosition.CenterScreen;
            GestionDeInsumos.Show();
            this.Hide();
        }

        private void btnGestionEstudios_Click(object sender, EventArgs e)
        {
            Form GestionDeEstudios = new frmGestionarEstudios();
            GestionDeEstudios.StartPosition = FormStartPosition.CenterScreen;
            GestionDeEstudios.Show();
            this.Hide();
        }
        private void btnListaEsperaEstudiosClinicos_Click(object sender, EventArgs e)
        {
            frmAgendaEstudiosClinicos listaEsperaEstudiosClinicosForm = new frmAgendaEstudiosClinicos(gestionarInsumosForm);
            listaEsperaEstudiosClinicosForm.StartPosition = FormStartPosition.CenterScreen;
            listaEsperaEstudiosClinicosForm.Show();
            this.Hide();
        }

        
    }
}
