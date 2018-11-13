using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private string dni;
        private DateTime nacimiento;
        private string direccion;

        public Alumno(string nombre, string apellido, string dni, DateTime nacimiento, string direccion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.nacimiento = nacimiento;
            this.direccion = direccion;
        }

        public String Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public String Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public String DNI
        {
            get
            {
                return this.dni;
            }
        }
        public string Direccion
        {
            get
            {
                return this.dni;
            }
        }
        public DateTime Nacimiento
        {
            get
            {
                return this.nacimiento;
            }
        }
    }
}
