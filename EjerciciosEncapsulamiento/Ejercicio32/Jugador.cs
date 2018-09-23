using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
	public class Jugador
	{
		private int dni;
		private string nombre;
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

		public int Dni
		{
			get { return this.dni; }
			set { this.dni = value; }
		}

		public string Nombre
		{
			get { return this.nombre; }
			set { this.nombre = value; }
		}

		private Jugador()
		{
			this.partidosJugados = 0;
			this.totalGoles = 0;
		}

		public Jugador(int dni, string nombre) : this()
		{
			this.dni = dni;
			this.nombre = nombre;
		}

		public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
		{
			this.dni = dni;
			this.nombre = nombre;
			this.partidosJugados = totalPartidos;
			this.totalGoles = totalGoles;
		}

		public string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(String.Format("DNI {0}", this.dni));
			sb.AppendLine(String.Format("Nombre {0}", this.nombre));
			sb.AppendLine(String.Format("Total partidos {0}", this.PartidosJugados));
			sb.AppendLine(String.Format("Total goles {0}", this.TotalGoles));
			sb.AppendLine(String.Format("Promedio goles {0}", this.PromedioGoles));
			return sb.ToString();
		}

		public static bool operator ==(Jugador jugadorUno, Jugador jugadorDos)
		{
			return jugadorUno.dni == jugadorDos.dni;
		}

		public static bool operator !=(Jugador jugadorUno, Jugador jugadorDos)
		{
			return !(jugadorUno == jugadorDos);
		}

	}
}
