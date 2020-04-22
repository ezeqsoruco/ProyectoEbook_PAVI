using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class Venta
    {
        private int nroFactura;
        private Sitio sitio;
        private DateTime fecha;
        private Persona cliente;
        private CorreoEmpresa empresa;
        private Descuento descuento;

        public Venta(int nroFactura, Sitio sitio, DateTime fecha, Persona cliente, CorreoEmpresa empresa, Descuento descuento)
        {
            this.nroFactura = nroFactura;
            this.sitio = sitio;
            this.fecha = fecha;
            this.cliente = cliente;
            this.empresa = empresa;
            this.descuento = descuento;
        }

        public int NroFactura
        {
            get { return nroFactura; }
            set { nroFactura = value; }
        }

        public Sitio Sitio
        {
            get { return sitio; }
            set { sitio = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Persona Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public CorreoEmpresa Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public Descuento Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
    }
}
