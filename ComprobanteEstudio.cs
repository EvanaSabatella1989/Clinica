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
    public partial class frmComprobante : Form
    {
        public frmComprobante(int idEstudio, string tipoEstudio, DateTime fecha, int dniPaciente, string nombrePaciente, string apellidoPaciente)
        {
            InitializeComponent();
            lblIdEstudio.Text = $"ID Estudio: {idEstudio}";
            lblTipoEstudio.Text = $"Tipo de Estudio: {tipoEstudio}";
            lblFecha.Text = $"Fecha: {fecha.ToString("dd/MM/yyyy")}";
            lblDniPaciente.Text = $"DNI del Paciente: {dniPaciente}";
            lblNombrePaciente.Text = $"Nombre: {nombrePaciente}";
            lblApellidoPaciente.Text = $"Apellido: {apellidoPaciente}";
            DateTime fechaRetiro = fecha.AddDays(2);
            lblFechaRetiro.Text = $"Retirar estudio a partir del: {fechaRetiro.ToString("dd/MM/yyyy")}";
        }
    }
}