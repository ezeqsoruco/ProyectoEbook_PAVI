using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class Genero
    {
        private string nombre;

        public Genero(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
