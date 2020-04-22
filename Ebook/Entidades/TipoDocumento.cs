using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class TipoDocumento
    {
        private string nombre;

        public TipoDocumento(string nombre)
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
