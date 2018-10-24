using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T: Equipo
    {
        private static Random randomEquipos;
        private static Random randomResultados;
        private List<T> equipos;
        private string nombre;

        public string JugarPartido
        {
            get
            {
                return this.CalcularPartido(this.equipos[Torneo<T>.randomEquipos.Next(0, this.equipos.Count)],
                    this.equipos[Torneo<T>.randomEquipos.Next(0, this.equipos.Count)]);
            }
        }

        static Torneo()
        {
            Torneo<T>.randomEquipos = new Random();
            Torneo<T>.randomResultados = new Random();
        }

        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }

        public static bool operator ==(T equipo, Torneo<T> torneo)
        {
            foreach(T equipoEnTorneo in torneo.equipos)
            {
                if (equipo == equipoEnTorneo)
                    return true;
            }
            return false;
        }

        public static bool operator !=(T equipo, Torneo<T> torneo)
        {
            return !(equipo == torneo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (equipo != torneo)
                torneo.equipos.Add(equipo);
            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.nombre);
            foreach(T equipo in this.equipos)
            {
                sb.AppendLine(equipo.Ficha());
            }
            return sb.ToString();
        }

        private string CalcularPartido(T equipoUno, T equipoDos)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1} - {2} {3}\n",
                equipoUno.Nombre, Torneo<T>.randomResultados.Next(0, 100), Torneo<T>.randomResultados.Next(0, 100), equipoDos.Nombre);
            return sb.ToString();
        }
    }
}
