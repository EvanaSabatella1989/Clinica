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
    public partial class frmAgregarEstudio : Form
    {
        private DataGridView dgvEstudios; 

        public frmAgregarEstudio(DataGridView dgvEstudios)
        {
            InitializeComponent();
            this.dgvEstudios = dgvEstudios;
            cmbTipoEstudio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregarEstudio_Click(object sender, EventArgs e)
        {
            int idEstudio;
            if (!int.TryParse(txtIdEstudio.Text, out idEstudio))
            {
                MessageBox.Show("El ID del estudio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (cmbTipoEstudio.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de estudio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            int dniPaciente;
            if (!int.TryParse(txtDniPaciente.Text, out dniPaciente))
            {
                MessageBox.Show("El DNI del paciente debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tipoEstudio = cmbTipoEstudio.SelectedItem.ToString();
            DateTime fechaEstudio = dtpFechaEstudio.Value;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvEstudios);
            fila.Cells[0].Value = idEstudio;
            fila.Cells[1].Value = tipoEstudio;
            fila.Cells[2].Value = dniPaciente;
            fila.Cells[5].Value = fechaEstudio.ToShortDateString();
            dgvEstudios.Rows.Add(fila);

            this.Close();
        }
    }
}