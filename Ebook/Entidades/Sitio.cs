using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class Sitio
    {
        private string cuil;
        private string razonSocial;
        private string calle;
        private int numeroCalle;
        private Barrio barrio;
        private string url;
        private int anioInicioVentas;

        public Sitio(string cuil, string razonSocial, string calle, int numeroCalle, Barrio barrio, string url, int anioInicioVentas)
        {
            this.cuil = cuil;
            this.razonSocial = razonSocial;
            this.calle = calle;
            this.numeroCalle = numeroCalle;
            this.barrio = barrio;
            this.url = url;
            this.anioInicioVentas = anioInicioVentas;
        }

        public string Cuil
        {
            get { return cuil ; }
            set { cuil = value; }
        }

        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }

        public string Calle
        {
            get { return calle; }
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

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public int AnioInicioVentas
        {
            get { return anioInicioVentas; }
            set { anioInicioVentas = value; }
        }
    }
}
