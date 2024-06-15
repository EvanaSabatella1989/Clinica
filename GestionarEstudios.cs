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
            dgvEstudios.AllowUserToAddRows = false;

            dgvEstudios.CellFormatting += dgvEstudios_CellFormatting;
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();

            frmMenu menu = new frmMenu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void btnAgregarEstudio_Click(object sender, EventArgs e)
        {
            frmAgregarEstudio agregarEstudioForm = new frmAgregarEstudio(dgvEstudios);
            agregarEstudioForm.StartPosition = FormStartPosition.CenterScreen;
            agregarEstudioForm.ShowDialog();
        }

        private void dgvEstudios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvEstudios.Columns["Acciones"].Index && e.RowIndex >= 0)
            {
                e.Value = "Generar comprobante";
            }
        }

        private void dgvEstudios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEstudios.Columns["Acciones"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvEstudios.Rows[e.RowIndex];

                int idEstudio = Convert.ToInt32(filaSeleccionada.Cells["IdEstudio"].Value);
                string tipoEstudio = filaSeleccionada.Cells["TipoEstudio"].Value.ToString();
                DateTime fecha = Convert.ToDateTime(filaSeleccionada.Cells["Fecha"].Value);
                int dniPaciente = Convert.ToInt32(filaSeleccionada.Cells["DniPaciente"].Value);
                string nombrePaciente = filaSeleccionada.Cells["NombrePaciente"].Value != null ? filaSeleccionada.Cells["NombrePaciente"].Value.ToString() : string.Empty;

                string apellidoPaciente = filaSeleccionada.Cells["ApellidoPaciente"].Value != null ? filaSeleccionada.Cells["ApellidoPaciente"].Value.ToString() : string.Empty;

                MostrarComprobante(idEstudio, tipoEstudio, fecha, dniPaciente, nombrePaciente, apellidoPaciente);
            }
        }
        private void MostrarComprobante(int idEstudio, string tipoEstudio, DateTime fecha, int dniPaciente, string nombrePaciente, string apellidoPaciente)
        {
            frmComprobante comprobanteForm = new frmComprobante(idEstudio, tipoEstudio, fecha, dniPaciente, nombrePaciente, apellidoPaciente);
            comprobanteForm.ShowDialog();
        }
    
    }
}
