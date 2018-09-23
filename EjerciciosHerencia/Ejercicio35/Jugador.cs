using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
	public class Jugador: Persona
	{
		private int partidosJugados;
		private int totalGoles;

		public int PartidosJugados
		{
			get { return this.partidosJugados; }

		}

		public int TotalGoles
		{
			get { return this.totalGoles; }
		}

		public float PromedioGoles
		{
			get { return this.totalGoles / this.partidosJugados; }
		}

		public Jugador(int dni, string nombre) : base(dni, nombre)
		{
			this.partidosJugados = 0;
			this.totalGoles = 0;
		}

		public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): base(dni, nombre)
		{
			this.partidosJugados = totalPartidos;
			this.totalGoles = totalGoles;
		}

		public string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(base.MostrarDatos());
			sb.AppendLine(String.Format("Total partidos {0}", this.PartidosJugados));
			sb.AppendLine(String.Format("Total goles {0}", this.TotalGoles));
			sb.AppendLine(String.Format("Promedio goles {0}", this.PromedioGoles));
			return sb.ToString();
		}

		public static bool operator ==(Jugador jugadorUno, Jugador jugadorDos)
		{
			return jugadorUno.Dni == jugadorDos.Dni;
		}

		public static bool operator !=(Jugador jugadorUno, Jugador jugadorDos)
		{
			return !(jugadorUno == jugadorDos);
		}

	}
}
