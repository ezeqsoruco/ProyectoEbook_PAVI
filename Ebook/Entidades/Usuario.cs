using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class Usuario
    {
        private string nombreUsuario;
        private string contrasenia;

        public Usuario(string nombreUsuario, string contrasenia)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Contrasenia
        {
            set { nombreUsuario = value; }
        }
    }
}
