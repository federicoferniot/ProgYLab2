using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_Library
{
    public class Accionista: Persona
    {
        private int porcionAccionaria;

        public int PorcionAccionaria
        {
            get { return porcionAccionaria; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.porcionAccionaria = value;
                }
            }
        }

        public Accionista(string nombre, string apellido, int porcionAccionaria): base(nombre, apellido)
        {
            this.PorcionAccionaria = porcionAccionaria;
        }

        public override string PosicionSocietaria()
        {
            return String.Format("Accionista con el {0}% de la porción accionaria", this.PorcionAccionaria);
        }

        public static bool operator ==(Accionista accionistaUno, Accionista accionistaDos)
        {
            return (accionistaUno.PorcionAccionaria == accionistaDos.PorcionAccionaria);
        }

        public static bool operator !=(Accionista accionistaUno, Accionista accionistaDos)
        {
            return !(accionistaUno == accionistaDos);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine(this.PosicionSocietaria());
            return sb.ToString();
        }

    }
}
