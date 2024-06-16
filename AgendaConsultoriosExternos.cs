using Clinica_SePrice.Datos;
using System;
using System.Windows.Forms;

namespace Clinica_SePrice
{
    public partial class frmAgendaConsultoriosExternos : Form
    {
        public frmAgendaConsultoriosExternos()
        {
            InitializeComponent();
            this.dgvAgendaConsultorios.AllowUserToAddRows = false;


        }

        public void AgregarTurno(DateTime fecha, string horario, string dni, string nombre, string apellido, string medico, string especialidad)
        {
            int id = dgvAgendaConsultorios.Rows.Count + 1;

            dgvAgendaConsultorios.Rows.Add(id, fecha.ToShortDateString(), horario, dni, nombre, apellido, medico, especialidad, "Acciones");
        }

        public void CambiarEstadoBotonAcreditadoEnDGV(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dgvAgendaConsultorios.Rows.Count)
            {
                dgvAgendaConsultorios.Rows[rowIndex].Cells["colAcciones"].Value = "Acreditado";
            }
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            frmGenerarTurno generarTurno = new frmGenerarTurno();
            generarTurno.FormAgendaConsultoriosExternos = this;
            generarTurno.StartPosition = FormStartPosition.CenterScreen;
            generarTurno.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmSeccion seccionForm = new frmSeccion();
            seccionForm.StartPosition = FormStartPosition.CenterScreen;
            seccionForm.Show();
            this.Close();
        }
    }
}
