using System;
using System.Windows.Forms;

namespace Clinica_SePrice
{
    public partial class frmPacientePrioritario : Form
    {
        private frmAgendaEstudiosClinicos _frmListaEspera;

        public frmPacientePrioritario(frmAgendaEstudiosClinicos frmListaEspera)
        {
            InitializeComponent();
            _frmListaEspera = frmListaEspera;

            cbTipoEstudio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool EsNumeroValido(string dni)
        {
            return int.TryParse(dni, out _);
        }

        private void btnAgregarPacientePrioritario_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();
            if (!EsNumeroValido(dni))
            {
                MessageBox.Show("El número de DNI ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                txtDni.SelectAll();
                return;
            }

            if (cbTipoEstudio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un tipo de estudio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tipoEstudio = cbTipoEstudio.SelectedItem.ToString();

            DataGridView dgv = _frmListaEspera.ObtenerDataGridViewPorTipoEstudio(tipoEstudio);

            if (dgv == null)
            {
                MessageBox.Show("No se encontró el DataGridView correspondiente para el tipo de estudio seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = -1;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["colHorario" + tipoEstudio].Value != null && row.Cells["colHorario" + tipoEstudio].Value.ToString() == "Prioritario")
                {
                    index = row.Index + 1;
                    break;
                }
                else if (row.Cells["colHorario" + tipoEstudio].Value != null && row.Cells["colHorario" + tipoEstudio].Value.ToString() != "Prioritario")
                {
                    index = row.Index;
                    break;
                }
            }

            if (index == -1)
            {
                dgv.Rows.Insert(0, null, "Prioritario", dni, null, null, null);
            }
            else
            {
                dgv.Rows.Insert(index, null, "Prioritario", dni, null, null, null);
            }

            string mensaje = $"Paciente prioritario agregado correctamente.\n\nDNI: {dni}\nTipo de estudio: {tipoEstudio}";
            MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();

            this.Close();
        }


        private void LimpiarCampos()
        {
            txtDni.Text = "";
            cbTipoEstudio.SelectedIndex = -1;
        }
    }
}
