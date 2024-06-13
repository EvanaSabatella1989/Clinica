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
    public partial class frmAgregarInsumo : Form
    {
        private DataGridView dgvInsumos;

        public frmAgregarInsumo(DataGridView dgvInsumos)
        {
            InitializeComponent();
            this.dgvInsumos = dgvInsumos;
        }

        private void frmAgregarInsumo_Load(object sender, EventArgs e)
        {
            txtIdInsumo.Focus();
        }

        private void txtIdInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidadInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreInsumo.Text) || 
                string.IsNullOrWhiteSpace(txtIdInsumo.Text) ||
                string.IsNullOrWhiteSpace(txtCantidadInsumo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtIdInsumo.Text, out int idInsumo))
            {
                MessageBox.Show("El ID del insumo debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCantidadInsumo.Text, out int cantidadInsumo))
            {
                MessageBox.Show("La cantidad del insumo debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreInsumo = txtNombreInsumo.Text;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvInsumos);
            fila.Cells[0].Value = idInsumo;
            fila.Cells[1].Value = nombreInsumo;
            fila.Cells[2].Value = cantidadInsumo;

            dgvInsumos.Rows.Add(fila);

            this.Close();
        }
    }
}