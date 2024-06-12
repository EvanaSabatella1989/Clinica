using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso.Entidades
{
    enum ERol
    {
        ADMIN = 0,
        USER = 1
    }

    internal class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string contrasena;
        private ERol rol;

        //public Usuario() { }
        public Usuario(string nombre, string contrasena, ERol rol)
        {
            this.nombre = nombre;
            this.contrasena = contrasena;
            this.rol = rol;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public ERol Rol { get => rol; set => rol = value; }
    }
}