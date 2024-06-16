using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Clinica_SePrice.Datos;

namespace Clinica_SePrice
{
    public partial class frmAgendarTurnoEstudios : Form
    {
        private readonly Conexion conexion = Conexion.getInstancia();

        public frmAgendarTurnoEstudios()
        {
            InitializeComponent();
            dtpFecha.MinDate = DateTime.Today;
            dtpFecha.MaxDate = DateTime.Today.AddMonths(6);

            dtpFecha.ValueChanged += new EventHandler(dtpFecha_ValueChanged);
            dtpFecha_ValueChanged(this, EventArgs.Empty);

            cbHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoEstudio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            frmSeccion seccion = new frmSeccion();
            seccion.StartPosition = FormStartPosition.CenterScreen;
            seccion.Show();
        }

        private void frmNuevoPaciente_Click(object sender, EventArgs e)
        {
            frmRegistrarPaciente registroNuevoPacienteForm = new frmRegistrarPaciente();
            registroNuevoPacienteForm.StartPosition = FormStartPosition.CenterScreen;
            registroNuevoPacienteForm.Show();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            DayOfWeek dia = dtpFecha.Value.DayOfWeek;

            if (dia == DayOfWeek.Sunday)
            {
                lblHorario.Visible = false;
                cbHorario.Visible = false;
            }
            else
            {
                lblHorario.Visible = true;
                cbHorario.Visible = true;

                List<string> horarios = new List<string>();

                if (dia >= DayOfWeek.Monday && dia <= DayOfWeek.Friday)
                {
                    for (int hour = 7; hour < 17; hour++)
                    {
                        for (int minute = 0; minute < 60; minute += 15)
                        {
                            if (hour == 16 && minute > 45) break;
                            horarios.Add($"{hour:D2}:{minute:D2}");
                        }
                    }
                }
                else if (dia == DayOfWeek.Saturday)
                {
                    for (int hour = 7; hour < 13; hour++)
                    {
                        for (int minute = 0; minute < 60; minute += 15)
                        {
                            if (hour == 12 && minute > 45) break;
                            horarios.Add($"{hour:D2}:{minute:D2}");
                        }
                    }
                }
                cbHorario.Items.Clear();
                cbHorario.Items.AddRange(horarios.ToArray());

                if (cbHorario.Items.Count > 0)
                {
                    cbHorario.SelectedIndex = 0;
                }
            }
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DniExisteEnBaseDeDatos(dni))
            {
                MessageBox.Show("El DNI ingresado no está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbTipoEstudio.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de estudio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DayOfWeek dia = dtpFecha.Value.DayOfWeek;

            if (dia == DayOfWeek.Sunday)
            {
                MessageBox.Show("No se realizan estudios clínicos los domingos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Solicitud de estudio clínico realizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool DniExisteEnBaseDeDatos(string dni)
        {
            bool existe = false;

            try
            {
                using (MySqlConnection conn = conexion.CrearConexion())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM persona WHERE dni = @dni";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        existe = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el DNI en la base de datos: " + ex.Message);
            }

            return existe;
        }
    }
}
