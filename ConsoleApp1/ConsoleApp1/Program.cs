using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            int cantidad = 5;
            int acumulador=0;
            string numeroStr;
            int numero;
            float promedio=0;
            int maximo=int.MinValue, minimo=int.MaxValue;

            for (int i=0;i<cantidad ;i++)
            {
                numeroStr = "";

                while (!int.TryParse(numeroStr, out numero))
                {
                    Console.WriteLine("Ingrese un número");
                    numeroStr = Console.ReadLine();
                }
                acumulador += numero;
                if(numero>maximo)
                {
                    maximo = numero;
                }
                if(numero<minimo)
                {
                        minimo = numero;
                }
            }

            promedio = (float)acumulador / cantidad;
            Console.WriteLine("El promedio es {0:#,###.00}", promedio); //.ToString("N2"));
            Console.WriteLine("El máximo es {0}", maximo);
            Console.WriteLine("El minimo es {0}", minimo);
            Console.ReadKey();
        }
    }
}
