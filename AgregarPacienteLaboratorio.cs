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
    public partial class frmAgregarPacienteLaboratorio : Form
    {
        private frmAgendaEstudiosClinicos _frmListaEspera;
        private DateTime? _ultimoHorarioAgregado;

        public frmAgregarPacienteLaboratorio(frmAgendaEstudiosClinicos frmListaEspera, DateTime? ultimoHorarioAgregado)
        {
            InitializeComponent();

            _frmListaEspera = frmListaEspera ?? throw new ArgumentNullException(nameof(frmListaEspera));
            _ultimoHorarioAgregado = ultimoHorarioAgregado;

            DateTime turnoLimite = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 16, 45, 0);
            if (_frmListaEspera.ExisteTurnoExacto(turnoLimite))
            {
                chkAyuno.Visible = false;
                cbHorarios.Visible = false;
            }
            else
            {
                ConfigurarComboBoxHorarios();
            }
        }
        private void ConfigurarComboBoxHorarios()
        {
            cbHorarios.Items.Clear();

            DateTime horaBase = _ultimoHorarioAgregado ?? DateTime.Today.AddHours(7).AddMinutes(0);
            DateTime horaFin;

            if (_frmListaEspera.ExisteTurnoPosterior(new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 10, 45, 0)) && chkAyuno.Checked)
            {
                cbHorarios.Visible = false;
                return;
            }

            if (chkAyuno.Checked)
            {
                horaFin = DateTime.Today.AddHours(10).AddMinutes(45);
            }
            else
            {
                horaFin = DateTime.Today.AddHours(16).AddMinutes(45);
            }

            if (_frmListaEspera.ExisteTurnoExacto(new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 16, 45, 0)))
            {
                chkAyuno.Visible = false;
                cbHorarios.Visible = false;
                return;
            }

            while (horaBase <= horaFin)
            {
                cbHorarios.Items.Add(horaBase.ToString("HH:mm"));
                horaBase = horaBase.AddMinutes(15);
            }

            cbHorarios.DropDownStyle = ComboBoxStyle.DropDownList;

            if (cbHorarios.Items.Count > 0)
            {
                cbHorarios.SelectedIndex = 0;
            }

            cbHorarios.Visible = true;

            if (chkAyuno.Checked && _frmListaEspera.ExisteTurnoExacto(new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 10, 45, 0)))
            {
                cbHorarios.Visible = false;
            }
        }

        private void chkAyuno_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarComboBoxHorarios();
        }


        private void chkPrioritario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrioritario.Checked)
            {
                chkAyuno.Visible = false;
                cbHorarios.Visible = false;
            }
            else
            {
                chkAyuno.Visible = true;
                cbHorarios.Visible = true;
                ConfigurarComboBoxHorarios();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime turnoLimite = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 16, 45, 0);
            if (_frmListaEspera.ExisteTurnoExacto(turnoLimite))
            {
                if (!chkPrioritario.Checked)
                {
                    MessageBox.Show("Sólo se aceptan estudios prioritarios en este momento del día.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            DateTime turnoLimite11_00 = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 11, 0, 0);
            if (chkAyuno.Checked && cbHorarios.SelectedItem != null)
            {
                string horarioSeleccionado = cbHorarios.SelectedItem.ToString();
                DateTime horario;
                if (DateTime.TryParseExact(horarioSeleccionado, "HH:mm", null, System.Globalization.DateTimeStyles.None, out horario))
                {
                    if (horario.TimeOfDay > new TimeSpan(11, 0, 0))
                    {
                        MessageBox.Show("No se pueden realizar estudios de laboratorio que requieren ayuno después de las 11:00.");
                        return;
                    }
                }
            }

            string dni = txtDni.Text.Trim();

            if (!EsNumeroValido(txtDni.Text.Trim()))
            {
                MessageBox.Show("El número de DNI ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridView dgvLaboratorio = _frmListaEspera.ObtenerDataGridViewLaboratorio();

            if (chkPrioritario.Checked)
            {
                int index = -1;
                foreach (DataGridViewRow row in dgvLaboratorio.Rows)
                {
                    if (row.Cells["colHorarioLaboratorio"].Value != null && row.Cells["colHorarioLaboratorio"].Value.ToString() == "Prioritario")
                    {
                        index = row.Index + 1;
                        break;
                    }
                }

                if (index == -1)
                {
                    index = 0;
                }

                dgvLaboratorio.Rows.Insert(index, null, "Prioritario", dni, null, null, null);
            }
            else
            {
                if (cbHorarios.SelectedItem == null)
                {
                    MessageBox.Show("No se pueden realizar estudios de laboratorio que requieren ayuno después de las 11:00.");
                    return;
                }

                string horario = cbHorarios.SelectedItem.ToString();

                _ultimoHorarioAgregado = DateTime.ParseExact(horario, "HH:mm", null).AddMinutes(15);

                if (_ultimoHorarioAgregado > DateTime.Today.AddHours(16).AddMinutes(45))
                {
                    _ultimoHorarioAgregado = DateTime.Today.AddHours(16).AddMinutes(45);
                }

                dgvLaboratorio.Rows.Add(null, horario, dni, null, null, null);
            }

            _frmListaEspera.UltimoHorarioAgregadoLaboratorio = _ultimoHorarioAgregado;

            ConfigurarComboBoxHorarios();

            LimpiarControles();

            this.Close();
        }


        private bool EsNumeroValido(string dni)
        {
            return int.TryParse(dni, out _);
        }

        private void LimpiarControles()
        {
            txtDni.Text = string.Empty;

            if (cbHorarios.Items.Count > 0)
            {
                cbHorarios.SelectedIndex = 0;
            }

            chkAyuno.Checked = false;
            chkPrioritario.Checked = false;
            chkAyuno.Visible = true;
            cbHorarios.Visible = true;
        }
    }
}
