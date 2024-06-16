namespace Clinica_SePrice
{
    public partial class frmAgendarTurnoEstudios : Form
    {
        public frmAgendarTurnoEstudios()
        {
            InitializeComponent();
            dtpFecha.MinDate = DateTime.Today;
            dtpFecha.MaxDate = DateTime.Today.AddMonths(6);


            dtpFecha.ValueChanged += new EventHandler(dtpFecha_ValueChanged);
            dtpFecha_ValueChanged(this, EventArgs.Empty);

            cbHorario.DropDownStyle = ComboBoxStyle.DropDownList;


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
    }
}
