using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class CorreoEmpresa
    {
        private string nombre;
        private string calle;
        private int numeroCalle;
        private Barrio barrio;

        public CorreoEmpresa(string nombre, string calle, int numeroCalle, Barrio barrio)
        {
            this.nombre = nombre;
            this.calle = calle;
            this.numeroCalle = numeroCalle;
            this.barrio = barrio;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string Calle
        {
            get { return calle;  }
            set { calle = value; }
        }

        public int NumeroCalle
        {
            get { return numeroCalle; }
            set { numeroCalle = value; }
        }

        public Barrio Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }
    }
}
