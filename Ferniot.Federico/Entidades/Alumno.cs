using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno: Persona
    {
        private short anio;
        private Divisiones division;

        public string AnioDivision
        {
            get
            {
                return String.Format("{0}º{1}", this.anio, this.division.ToString());
            }
        }

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ExponerDatos());
            sb.AppendLine(this.AnioDivision);

            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string documento)
        {
            bool documentoValido = false;
            if(documento.Length == 9)
            {
                for(int i=0; i<9; i++)
                {
                    if ((i != 2 && i != 7) && !int.TryParse(documento[i].ToString(), out int numero))
                    {
                        documentoValido = false;
                        break;
                    }
                    else if ((i == 2 || i == 7) && documento[i] != '-')
                    {
                        documentoValido = false;
                        break;
                    }
                    documentoValido = true;
                }
            }
            return documentoValido;
        }
    }
}
