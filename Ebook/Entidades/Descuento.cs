using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class Descuento
    {
        private int montoInfDesc;
        private DateTime fechaAltaDesc;
        private int montoSupDesc;
        private DateTime fechaBaja;
        private int porcentaje;

        public Descuento(int montoInfDesc, DateTime fechaAltaDesc, int montoSupDesc, DateTime fechaBaja, int porcentaje)
        {
            this.montoInfDesc = montoInfDesc;
            this.fechaAltaDesc = fechaAltaDesc;
            this.montoSupDesc = montoSupDesc;
            this.fechaBaja = fechaBaja;
            this.porcentaje = porcentaje;
        }

        public Descuento(int montoInfDesc, int montoSupDesc, int porcentaje)
        {
            this.montoInfDesc = montoInfDesc;
            this.FechaAltaDesc = DateTime.Today;
            this.montoSupDesc = montoSupDesc;
            this.porcentaje = porcentaje;
        }
        public int MontoInfDesc
        {
            get { return montoInfDesc; }
            set { montoInfDesc = value; }
        }

        public DateTime FechaAltaDesc
        {
            get { return fechaAltaDesc; }
            set { fechaAltaDesc = value; }
        }

        public int MontoSupDesc
        {
            get { return montoSupDesc; }
            set { montoSupDesc = value; }
        }

        public DateTime FechaBaja
        {
            get { return fechaBaja; }
            set { fechaBaja = value; }
        }

        public int Porcentaje
        {
            get { return porcentaje; }
            set { porcentaje = value; }
        }
    }
}
