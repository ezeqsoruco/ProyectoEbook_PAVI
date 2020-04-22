using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class Localidad
    {
        private string nombre;
        private Provincia provincia;

        public Localidad(string nombre, Provincia provincia)
        {
            this.nombre = nombre;
            this.provincia = provincia;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Provincia Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }
    }
}
