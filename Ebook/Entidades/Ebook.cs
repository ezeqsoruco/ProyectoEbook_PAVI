using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class Ebook
    {
        private int codigo;
        private Genero genero;
        private string titulo;
        private string descripcion;
        private int anioEdicion;
        private int nroEdicion;
        private Editorial editorial;
        //Deberia tener un precio, cosa que no esta contemplada en la normalizacion de la base de datos
        private int precio;

        public Ebook(int codigo, Genero genero, string titulo, string descripcion, int anioEdicion, int nroEdicion, Editorial editorial, int precio)
        {
            this.codigo = codigo;
            this.genero = genero;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.anioEdicion = anioEdicion;
            this.nroEdicion = nroEdicion;
            this.editorial = editorial;
            this.precio = precio;
        }
        
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Genero Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int AnioEdicion
        {
            get { return anioEdicion; }
            set { anioEdicion = value; }
        }

        public int NroEdicion
        {
            get { return nroEdicion; }
            set { nroEdicion = value; }
        }

        public Editorial Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
