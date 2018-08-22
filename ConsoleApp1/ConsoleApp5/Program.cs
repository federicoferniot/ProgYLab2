using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";
            int numero;
            string numeroStr = "";
            while (!int.TryParse(numeroStr, out numero))
            {
                Console.WriteLine("Ingrese un número");
                numeroStr = Console.ReadLine();
            }
            for(int i=2; i<numero; i++)
            {
                if(Sumar(1, i)==Sumar(i, numero))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        static int Sumar(int desde, int hasta)
        {
            int acumulador = 0;
            for(int i=desde; i<=hasta; i++)
            {
                acumulador += i;
            }
            return acumulador;
        }
    }
}
