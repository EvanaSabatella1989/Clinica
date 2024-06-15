using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clinica_SePrice.Entidades
{
    internal class Insumo
    {
        private int? idInsumo;
        private string nombreInsumo;
        private int cantidadInsumo;

        public Insumo()
        {
        }

        public Insumo(int? id, string nombre, int cantidad)
        {
            this.idInsumo = id;
            this.nombreInsumo = nombre;
            this.cantidadInsumo = cantidad;
        }

        public int? IdInsumo
        {
            get { return idInsumo; }
            set { idInsumo = value; }
        }

        public string NombreInsumo
        {
            get { return nombreInsumo; }
            set { nombreInsumo = value; }
        }

        public int CantidadInsumo
        {
            get { return cantidadInsumo; }
            set { cantidadInsumo = value; }
        }
    }
}