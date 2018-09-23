using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
	class Program
	{
		static void Main(string[] args)
		{
			Random numeroRandom = new Random();
			int[] array = new int[20];
			for (int i = 0; i < 20; i++)
			{
				array[i] = numeroRandom.Next(-1000, 1000);
			}
			foreach (int numero in array)
			{
				Console.Write("{0} ", numero);
			}
			Console.ReadKey();
		}
	}
}
