using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_SePrice.Entidades
{
    public class Estudio
    {
        private int idEstudio;
        private string tipoEstudio;
        private DateTime fecha;
        private int dniPaciente;

        public Estudio()
        {
        }

        public Estudio(int idEstudio, string tipoEstudio, DateTime fecha, int dniPaciente)
        {
            this.idEstudio = idEstudio;
            this.tipoEstudio = tipoEstudio;
            this.fecha = fecha;
            this.dniPaciente = dniPaciente;
        }

        public int IdEstudio
        {
            get { return idEstudio; }
            set { idEstudio = value; }
        }

        public string TipoEstudio
        {
            get { return tipoEstudio; }
            set { tipoEstudio = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int DniPaciente
        {
            get { return dniPaciente; }
            set { dniPaciente = value; }
        }
    }
}