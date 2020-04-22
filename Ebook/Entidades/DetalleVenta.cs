using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class DetalleVenta
    {
        private int nroVenta;
        private Ebook libro;
        private int cantidad;
        private int precio;

        public DetalleVenta(Venta venta, Ebook libro, int cantidad, int precio)
        {
            this.nroVenta = venta.NroFactura;
            this.libro = libro;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public DetalleVenta(int nroVenta, Ebook libro, int cantidad, int precio)
        {
            this.nroVenta = nroVenta;
            this.libro = libro;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public int NroVenta
        {
            get { return nroVenta; }
            set { nroVenta = value; }
        }

        private Ebook Libro
        {
            get { return libro; }
            set { libro = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
