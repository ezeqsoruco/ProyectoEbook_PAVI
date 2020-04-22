using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class Premio
    {
        private string nombre;
        private Institucion institucion;

        public Premio(string nombre, Institucion institucion)
        {
            this.nombre = nombre;
            this.institucion = institucion;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Institucion Institucion
        {
            get { return institucion; }
            set { institucion = value; }
        }
    }
}
