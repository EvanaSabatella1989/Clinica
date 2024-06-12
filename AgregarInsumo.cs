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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreInsumo = txtNombreInsumo.Text;
            int cantidadInsumo = Convert.ToInt32(txtCantidadInsumo.Text);
            int idInsumo = Convert.ToInt32(txtIdInsumo.Text);

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