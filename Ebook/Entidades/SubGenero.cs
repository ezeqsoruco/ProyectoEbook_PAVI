using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class SubGenero
    {
        private Genero genero;
        private string nombre;

        public SubGenero(Genero genero, string nombre)
        {
            this.genero = genero;
            this.nombre = nombre;
        }

        public Genero Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
