using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinica_SePrice
{
    public partial class frmAgendaEstudiosClinicos : Form
    {
        private DateTime? _ultimoHorarioAgregadoLaboratorio;
        private frmGestionarInsumos gestionarInsumosForm;

        public frmAgendaEstudiosClinicos(frmGestionarInsumos gestionarInsumosForm)
        {
            InitializeComponent();
            this.gestionarInsumosForm = gestionarInsumosForm;
            EliminarFilaEnBlanco();
            dgvRadiografia.CellContentClick += dgvRadiografia_CellContentClick;

            foreach (TabPage tabPage in tbEstudios.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is DataGridView dgv)
                    {
                        dgv.UserDeletingRow += dgv_EliminarFila;
                    }
                }
            }
        }

        public DateTime? UltimoHorarioAgregadoLaboratorio
        {
            get { return _ultimoHorarioAgregadoLaboratorio; }
            set { _ultimoHorarioAgregadoLaboratorio = value; }
        }

        private void btnAgregarPacienteLaboratorio_Click(object sender, EventArgs e)
        {
            frmAgregarPacienteLaboratorio agregarPacienteLaboratorioForm = new frmAgregarPacienteLaboratorio(this, _ultimoHorarioAgregadoLaboratorio);
            agregarPacienteLaboratorioForm.StartPosition = FormStartPosition.CenterScreen;
            agregarPacienteLaboratorioForm.Show();
        }

        public DataGridView ObtenerDataGridViewLaboratorio()
        {
            foreach (TabPage tabPage in tbEstudios.TabPages)
            {
                if (tabPage.Name == "tabLaboratorio")
                {
                    foreach (Control control in tabPage.Controls)
                    {
                        if (control is DataGridView)
                        {
                            return (DataGridView)control;
                        }
                    }
                }
            }
            return null;
        }

        public void AgregarPacientePrioritario(string tipoEstudio, string dni)
        {
            DataGridView dgv = ObtenerDataGridViewPorTipoEstudio(tipoEstudio);
            if (dgv != null)
            {
                dgv.Rows.Add("Prioritario", dni);
            }
            else
            {
                MessageBox.Show("No se encontró el DataGridView correspondiente para el tipo de estudio seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataGridView ObtenerDataGridViewPorTipoEstudio(string tipoEstudio)
        {
            switch (tipoEstudio)
            {
                case "Laboratorio":
                    return ObtenerDataGridViewPorNombre("dgvLaboratorio");
                case "Ecografía":
                    return ObtenerDataGridViewPorNombre("dgvEcografia");
                case "Electrocardiograma":
                    return ObtenerDataGridViewPorNombre("dgvElectrocardiograma");
                case "Radiografía":
                    return ObtenerDataGridViewPorNombre("dgvRadiografia");
                case "Tomografía":
                    return ObtenerDataGridViewPorNombre("dgvTomografia");
                default:
                    return null;
            }
        }

        private DataGridView ObtenerDataGridViewPorNombre(string nombre)
        {
            foreach (TabPage tabPage in tbEstudios.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is DataGridView dgv && dgv.Name == nombre)
                    {
                        return dgv;
                    }
                }
            }
            return null;
        }

        public bool ExisteTurnoPosterior(DateTime horarioLimite)
        {
            foreach (DataGridViewRow row in dgvLaboratorio.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string horarioString = row.Cells[0].Value.ToString();

                    if (horarioString.Equals("Prioritario", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    DateTime horario;
                    if (DateTime.TryParseExact(horarioString, "HH:mm", null, System.Globalization.DateTimeStyles.None, out horario))
                    {
                        if (horario >= horarioLimite)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"El valor '{horarioString}' no es un horario válido.");
                    }
                }
            }
            return false;
        }

        private void frmNuevoPaciente_Click(object sender, EventArgs e)
        {
            frmRegistrarPaciente registroNuevoPacienteForm = new frmRegistrarPaciente();
            registroNuevoPacienteForm.StartPosition = FormStartPosition.CenterScreen;
            registroNuevoPacienteForm.Show();
        }

        private void btnPacientePrioritario_Click(object sender, EventArgs e)
        {
            frmPacientePrioritario pacientePrioritarioForm = new frmPacientePrioritario(this);
            pacientePrioritarioForm.StartPosition = FormStartPosition.CenterScreen;
            pacientePrioritarioForm.Show();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();

            frmMenu menu = new frmMenu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void EliminarFilaEnBlanco()
        {
            foreach (TabPage tabPage in tbEstudios.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is DataGridView dgv)
                    {
                        dgv.AllowUserToAddRows = false;
                        dgv.AllowUserToDeleteRows = true;
                        dgv.ReadOnly = true;

                        if (dgv.Rows.Count > 0 && dgv.Rows[dgv.Rows.Count - 1].IsNewRow)
                        {
                            dgv.Rows.RemoveAt(dgv.Rows.Count - 1);
                        }
                    }
                }
            }
        }

        private void dgv_EliminarFila(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este turno?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgvRadiografia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvRadiografia.Columns["colAccionesRadiografia"].Index)
            {
                string idInsumo = "00003"; 

                using (frmAcreditarPaciente frmAcreditar = new frmAcreditarPaciente(gestionarInsumosForm, idInsumo))
                {
                    DialogResult result = frmAcreditar.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string opcionSeleccionada = frmAcreditar.ObtenerOpcionSeleccionada();

                        if (!string.IsNullOrEmpty(opcionSeleccionada))
                        {
                            dgvRadiografia.Rows[e.RowIndex].Cells["colAccionesRadiografia"].Value = $"Acreditado ({opcionSeleccionada})";
                            dgvRadiografia.Rows[e.RowIndex].Cells["colAccionesRadiografia"].ReadOnly = true;
                        }
                    }
                }
            }
        }
    }
}

