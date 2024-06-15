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

            foreach (TabPage tabPage in tbEstudios.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is DataGridView dgv)
                    {
                        dgv.CellContentClick += dgv_CellContentClick;
                        foreach (DataGridViewColumn columna in dgv.Columns)
                        {
                            if (columna.Name.StartsWith("colAcciones"))
                            {
                                columna.ReadOnly = true;
                            }
                        }
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
                dgv.Rows.Add(null, "Prioritario", dni, null, null, null);
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

        public bool ExisteTurnoExacto(DateTime horario)
        {
            foreach (DataGridViewRow row in dgvLaboratorio.Rows)
            {
                if (row.Cells["colHorarioLaboratorio"].Value != null)
                {
                    string horarioString = row.Cells["colHorarioLaboratorio"].Value.ToString();

                    if (horarioString.Equals("Prioritario", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    DateTime horarioRow;
                    if (DateTime.TryParseExact(horarioString, "HH:mm", null, System.Globalization.DateTimeStyles.None, out horarioRow))
                    {
                        if (horarioRow == horario)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn columna = dgv.Columns[e.ColumnIndex];

                if (columna.Name.StartsWith("colAcciones"))
                {
                    string tipoEstudio = ObtenerTipoEstudioPorDataGridView(dgv);

                    using (frmAcreditarPaciente frmAcreditar = new frmAcreditarPaciente(gestionarInsumosForm))
                    {
                        frmAcreditar.StartPosition = FormStartPosition.CenterScreen;
                        DialogResult result = frmAcreditar.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            string opcionSeleccionada = frmAcreditar.ObtenerOpcionSeleccionada();

                            if (!string.IsNullOrEmpty(opcionSeleccionada))
                            {
                                dgv.Rows[e.RowIndex].Cells[columna.Name].Value = $"Acreditado ({opcionSeleccionada})";
                                dgv.Rows[e.RowIndex].Cells[columna.Name].ReadOnly = true;
                            }
                        }
                    }
                }
            }
        }

        private string ObtenerTipoEstudioPorDataGridView(DataGridView dgv)
        {
            switch (dgv.Name)
            {
                case "dgvLaboratorio":
                    return "Laboratorio";
                case "dgvEcografia":
                    return "Ecografía";
                case "dgvElectrocardiograma":
                    return "Electrocardiograma";
                case "dgvRadiografia":
                    return "Radiografía";
                case "dgvTomografia":
                    return "Tomografía";
                default:
                    return string.Empty;
            }
        }
    }
}
