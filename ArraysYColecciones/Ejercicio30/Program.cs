using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
	class Program
	{
		static void Main(string[] args)
		{
			Competencia competencia = new Competencia(10, 2);
			AutoF1 autoUno = new AutoF1(1, "Escuderia");
			AutoF1 autoDos = new AutoF1(2, "Escuderia");
			AutoF1 autoTres = new AutoF1(3, "Escuderia");

			if (competencia + autoUno)
				Console.WriteLine("Se agrega auto uno a competencia");
			else
				Console.WriteLine("No se agrega a competencia auto uno");

			if (competencia + autoUno)
				Console.WriteLine("Se agrega auto uno a competencia");
			else
				Console.WriteLine("No se agrega a competencia auto uno");

			if (competencia + autoDos)
				Console.WriteLine("Se agrega auto dos a competencia");
			else
				Console.WriteLine("No se agrega a competencia auto dos");

			if (competencia + autoTres)
				Console.WriteLine("Se agrega auto tres a competencia");
			else
				Console.WriteLine("No se agrega a competencia auto tres");

			Console.WriteLine(competencia.MostrarDatos());
			Console.ReadKey();

		}
	}
}
