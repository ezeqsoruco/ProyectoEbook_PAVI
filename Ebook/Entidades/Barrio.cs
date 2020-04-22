using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    public class Barrio
    {
        private string nombre;
        private Localidad localidad;

        public Barrio(string nombre, Localidad localidad)
        {
            this.nombre = nombre;
            this.localidad = localidad;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Localidad Localidad
        {
            get { return localidad; }
            set { localidad = value;  }
        }
    }
}
