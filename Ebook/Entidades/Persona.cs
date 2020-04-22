using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private DateTime fechaNacimiento;
        private int nroDocumento;
        private TipoDocumento tipoDocumento;

        public Persona(string nombre, string apellido, string email, string telefono, DateTime fechaNacimiento, int nroDocumento, TipoDocumento tipoDocumento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento.Date;
            this.nroDocumento = nroDocumento;
            this.tipoDocumento = tipoDocumento;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int NroDocumento
        {
            get { return nroDocumento; }
            set { nroDocumento = value; }
        }

        public TipoDocumento TipoDocumento
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }
    }
}
