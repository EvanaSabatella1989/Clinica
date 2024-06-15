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
    public partial class frmAcreditarPaciente : Form
    {
        private frmGestionarInsumos gestionarInsumosForm;
        private string idInsumo;
        public frmAcreditarPaciente(frmGestionarInsumos gestionarInsumosForm = null, string idInsumo = null)
        {
            InitializeComponent();
            this.gestionarInsumosForm = gestionarInsumosForm;
            this.idInsumo = idInsumo;
        }

        private void btnAcreditar_Click(object sender, EventArgs e)
        {
            if (rbObraSocial.Checked || rbParticular.Checked)
            {
                this.DialogResult = DialogResult.OK;

                if (gestionarInsumosForm != null && !string.IsNullOrEmpty(idInsumo))
                {
                    gestionarInsumosForm.RestarInsumoPorId(idInsumo, 1);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una modalidad de acreditación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string ObtenerOpcionSeleccionada()
        {
            if (rbObraSocial.Checked)
            {
                return "Obra Social";
            }
            else if (rbParticular.Checked)
            {
                return "Particular";
            }
            return string.Empty;
        }
    }
}

