using Microsoft.VisualBasic;
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
    public partial class frmGestionarInsumos : Form
    {
        public frmGestionarInsumos()
        {
            InitializeComponent();
            dgvInsumos.ReadOnly = true;
            dgvInsumos.AllowUserToAddRows = false;

            foreach (DataGridViewRow row in dgvInsumos.Rows)
            {
                row.ReadOnly = true;
            }

        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            frmAgregarInsumo agregarInsumoForm = new frmAgregarInsumo(dgvInsumos);
            agregarInsumoForm.ShowDialog();
        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInsumos.Columns["ReponerInsumo"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvInsumos.Rows[e.RowIndex];

                string nombreInsumo = filaSeleccionada.Cells["NombreInsumo"].Value.ToString();

                int cantidadAReponer = 0;
                if (int.TryParse(Interaction.InputBox($"Ingrese la cantidad a reponer de {nombreInsumo}':", "Reponer Insumo"), out cantidadAReponer))
                {
                    int cantidadActual = Convert.ToInt32(filaSeleccionada.Cells["CantidadInsumo"].Value);
                    filaSeleccionada.Cells["CantidadInsumo"].Value = cantidadActual + cantidadAReponer;
                }
            }
        }

        private void dgvInsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInsumos.Columns[e.ColumnIndex].Name == "ReponerInsumo" && e.RowIndex >= 0)
            {
                string nombreInsumo = dgvInsumos.Rows[e.RowIndex].Cells["NombreInsumo"].Value.ToString();
                DataGridViewButtonCell cell = (DataGridViewButtonCell)dgvInsumos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Value = $"Reponer {nombreInsumo}";
            }
        }

        private void btnVolverInsumos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
