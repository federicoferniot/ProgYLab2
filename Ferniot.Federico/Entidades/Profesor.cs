using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor: Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad
        {
            get
            {
                return (int)(DateTime.Now - this.fechaIngreso).TotalDays;
            }
        }

        #region Constructores

        public Profesor(string nombre, string apellido, string documento): 
            base(nombre, apellido, documento)
        {
            
        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso): 
            this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        #endregion

        #region Métodos

        protected override bool ValidarDocumentacion(string documento)
        {
            return (documento.Length == 8);
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ExponerDatos());
            sb.AppendFormat("Antiguedad: {0} días\n", this.Antiguedad.ToString());

            return sb.ToString();
        }

        #endregion
    }
}
