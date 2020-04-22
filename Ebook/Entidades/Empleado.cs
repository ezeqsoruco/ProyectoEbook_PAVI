using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Entidades
{
    class Empleado
    {
        private int legajo;
        private int nroDocumento;
        private TipoDocumento tipoDocumento;
        private string calle;
        private int numeroCalle;
        private Barrio barrio;
        private DateTime fechaIngreso;
        private DateTime fechaEgreso;
        private Empleado supervisor;

        public Empleado(int legajo, int nroDocumento, TipoDocumento tipoDocumento, string calle, int numeroCalle, Barrio barrio, DateTime fechaIngreso, DateTime fechaEgreso, Empleado supervisor)
        {
            this.legajo = legajo;
            this.nroDocumento = nroDocumento;
            this.tipoDocumento = tipoDocumento;
            this.calle = calle;
            this.numeroCalle = numeroCalle;
            this.barrio = barrio;
            this.fechaIngreso = fechaIngreso;
            this.fechaEgreso = fechaEgreso;
            this.supervisor = supervisor;
        }

        public Empleado(int legajo, int nroDocumento, TipoDocumento tipoDocumento, string calle, int numeroCalle, Barrio barrio, DateTime fechaIngreso, DateTime fechaEgreso)
        {
            this.legajo = legajo;
            this.nroDocumento = nroDocumento;
            this.tipoDocumento = tipoDocumento;
            this.calle = calle;
            this.numeroCalle = numeroCalle;
            this.barrio = barrio;
            this.fechaIngreso = fechaIngreso;
            this.fechaEgreso = fechaEgreso;
        }

        public Empleado(int legajo, Persona persona, string calle, int numeroCalle, Barrio barrio, DateTime fechaIngreso, DateTime fechaEgreso, Empleado supervisor)
        {
            this.legajo = legajo;
            this.nroDocumento = persona.NroDocumento;
            this.tipoDocumento = persona.TipoDocumento;
            this.calle = calle;
            this.numeroCalle = numeroCalle;
            this.barrio = barrio;
            this.fechaIngreso = fechaIngreso;
            this.fechaEgreso = fechaEgreso;
            this.supervisor = supervisor;
        }

        public Empleado(int legajo, Persona persona, string calle, int numeroCalle, Barrio barrio, DateTime fechaIngreso, DateTime fechaEgreso)
        {
            this.legajo = legajo;
            this.nroDocumento = persona.NroDocumento;
            this.tipoDocumento = persona.TipoDocumento;
            this.calle = calle;
            this.numeroCalle = numeroCalle;
            this.barrio = barrio;
            this.fechaIngreso = fechaIngreso;
            this.fechaEgreso = fechaEgreso;
        }

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
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

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        
        public DateTime FechaEgreso
        {
            get { return fechaEgreso; }
            set { fechaEgreso = value; }
        }

        public Empleado Supervisor
        {
            get { return supervisor; }
            set { supervisor = value; }
        }
    }
}
