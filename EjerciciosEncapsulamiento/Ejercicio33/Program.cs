using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
	class Program
	{
		static void Main(string[] args)
		{
			Libro libro = new Libro();
			libro[0] = "Primer pagina";
			libro[0] = "Primer pagina modificada";
			libro[20] = "Segunda pagina";
			libro[1] = "Segunda pagina modificada";

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(libro[i]);
			}

			Console.ReadKey();
		}
	}
}
