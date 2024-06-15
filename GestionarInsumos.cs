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

            AgregarInsumoInicial("00003", "Placas Radiográficas", 300);

            foreach (DataGridViewRow row in dgvInsumos.Rows)
            {
                row.ReadOnly = true;
            }
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            frmAgregarInsumo agregarInsumoForm = new frmAgregarInsumo(dgvInsumos);
            agregarInsumoForm.StartPosition = FormStartPosition.CenterScreen;
            agregarInsumoForm.ShowDialog();
        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInsumos.Columns["ReponerInsumo"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvInsumos.Rows[e.RowIndex];

                string nombreInsumo = filaSeleccionada.Cells["NombreInsumo"].Value.ToString();

                int cantidadAReponer = 0;
                if (int.TryParse(Interaction.InputBox($"Ingrese la cantidad a reponer de {nombreInsumo}:", "Reponer Insumo"), out cantidadAReponer))
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

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();

            frmMenu menu = new frmMenu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void AgregarInsumoInicial(string idInsumo, string nombreInsumo, int cantidad)
        {
            if (dgvInsumos.Columns.Count == 0)
            {
                dgvInsumos.Columns.Add("IdInsumo", "ID del Insumo");
                dgvInsumos.Columns.Add("NombreInsumo", "Nombre del Insumo");
                dgvInsumos.Columns.Add("CantidadInsumo", "Cantidad");
                dgvInsumos.Columns.Add(new DataGridViewButtonColumn { Name = "ReponerInsumo", HeaderText = "Reponer", Text = "Reponer", UseColumnTextForButtonValue = true });
            }

            dgvInsumos.Rows.Add(idInsumo, nombreInsumo, cantidad);
        }

        public void RestarInsumoPorId(string idInsumo, int cantidadARestar)
        {
            foreach (DataGridViewRow row in dgvInsumos.Rows)
            {
                if (row.Cells["IdInsumo"].Value.ToString() == idInsumo)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["CantidadInsumo"].Value);
                    row.Cells["CantidadInsumo"].Value = cantidadActual - cantidadARestar;
                    break;
                }
            }
        }
    }
}
