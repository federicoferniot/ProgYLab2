using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
	class Program
	{
		static void Main(string[] args)
		{
			Equipo equipoNuevo = new Equipo(11, "Club equipo");
			Jugador jugadorUno = new Jugador(32346515, "Juan", 20, 10);
			Jugador jugadorDos = new Jugador(34351625, "Alberto", 10, 30);

			Console.WriteLine(jugadorUno.MostrarDatos());
			if (equipoNuevo + jugadorUno)
			{
				Console.WriteLine("Se agrego jugador uno");
			}
			else
			{
				Console.WriteLine("No se agrego jugador uno");
			}

			if (equipoNuevo + jugadorDos)
			{
				Console.WriteLine("Se agrego jugador dos");
			}
			else
			{
				Console.WriteLine("No se agrego jugador dos");
			}

			if (equipoNuevo + jugadorUno)
			{
				Console.WriteLine("Se agrego jugador uno");
			}
			else
			{
				Console.WriteLine("No se agrego jugador uno");
			}

			Console.ReadKey();
		}
	}
}
