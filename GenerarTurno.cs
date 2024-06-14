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
    public partial class GenerarTurno : Form
    {
        // Simulamos una base de datos de pacientes
        private Dictionary<string, string> pacientesRegistrados = new Dictionary<string, string>();
        public GenerarTurno()
        {
            InitializeComponent();
            // Suscribir el evento ValueChanged del DateTimePicker
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBoxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfoEspecialidad.Text = "Ha seleccionado la especialidad: " + comboBoxEspecialidad.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfoMedico.Text = "Ha seleccionado el médico/a: " + comboBoxMedico.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Limpiar la lista de horas disponibles
            listBox.Items.Clear();

            // Supongamos que las horas disponibles son de 9:00 a 17:00 cada media hora
            TimeSpan startTime = new TimeSpan(9, 0, 0);
            TimeSpan endTime = new TimeSpan(17, 0, 0);
            TimeSpan interval = new TimeSpan(0, 30, 0);

            for (TimeSpan time = startTime; time < endTime; time += interval)
            {
                listBox.Items.Add(time.ToString(@"hh\:mm"));
            }
        }

        private void btnConfirmaTurno_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una hora para el turno.");
                return;
            }
            String especialidad = comboBoxEspecialidad.Text;
            String medico = comboBoxMedico.Text;

            // Obtener la fecha y la hora seleccionadas
            DateTime selectedDate = dateTimePicker.Value.Date;
            string selectedTime = listBox.SelectedItem.ToString();
            DateTime selectedDateTime = DateTime.Parse(selectedDate.ToShortDateString() + " " + selectedTime);

            // Aquí se puede agregar lógica adicional para guardar la reserva en una base de datos o archivo

            MessageBox.Show($"Turno reservado para el {selectedDateTime.ToString("f")}, para {especialidad} con el/la Dr/a {medico}");
        }

        private void GenerarTurno_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVerificarDni_Click(object sender, EventArgs e)
        {
            string dni = textBoxDni.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.");
                return;
            }

            if (pacientesRegistrados.ContainsKey(dni))
            {
                MessageBox.Show("DNI verificado. Puede proceder a reservar un turno.");
                // Mostrar los controles de reserva de turno
                dateTimePicker.Visible = true;
                listBox.Visible = true;
                btnConfirmaTurno.Visible = true;
                //lbl.Visible = true;
                //labelHora.Visible = true;
            }
            else
            {
                MessageBox.Show("El DNI no está registrado. Debe registrarse primero.");
                // Llamar al formulario de registro (se implementará en el siguiente paso)
                //Form registrarPaciente = new RegistrarPaciente(dni, pacientesRegistrados);
                Form registrarPaciente = new RegistrarPaciente();
                registrarPaciente.ShowDialog();
            }
        }
    }
}
