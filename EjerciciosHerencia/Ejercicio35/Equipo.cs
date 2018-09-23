using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
	public class Equipo
	{
		private short cantidadJugadores;
		private List<Jugador> jugadores;
		private string nombre;

		private Equipo()
		{
			this.jugadores = new List<Jugador>();
		}

		public Equipo(short cantidad, string nombre) : this()
		{
			this.cantidadJugadores = cantidad;
			this.nombre = nombre;
		}

		public static bool operator +(Equipo equipo, Jugador jugador)
		{
			bool ingresado = false;
			bool perteneceAEquipo = false;
			if (equipo.jugadores.Count < equipo.cantidadJugadores)
			{
				foreach (Jugador jugadorEquipo in equipo.jugadores)
				{
					if (jugadorEquipo == jugador)
					{
						perteneceAEquipo = true;
					}
				}
			}
			if (!perteneceAEquipo)
			{
				equipo.jugadores.Add(jugador);
				ingresado = true;
			}
			return ingresado;
		}

	}
}
