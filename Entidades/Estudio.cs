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
        private int idPaciente; 

        public Estudio()
        {
        }

        public Estudio(int idEstudio, string tipoEstudio, DateTime fecha, int idPaciente)
        {
            this.idEstudio = idEstudio;
            this.tipoEstudio = tipoEstudio;
            this.fecha = fecha;
            this.idPaciente = idPaciente;
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

        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }
    }
}