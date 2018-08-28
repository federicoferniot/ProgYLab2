using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";
            int numero=0;
            int acumulador=0;
            int maximo=int.MinValue;
            int minimo=int.MaxValue;
            float promedio;
            string numeroStr;

            for (int i = 0; i < 10; i++)
            {
                numeroStr = "";
                while (!int.TryParse(numeroStr, out numero) || !Validacion.Validar(numero, -100, 100))
                {
                    Console.WriteLine("Ingrese un numero");
                    numeroStr = Console.ReadLine();
                }
                if(numero>maximo)
                {
                    maximo = numero;
                }
                if(numero<minimo)
                {
                    minimo = numero;
                }
                acumulador += numero;
            }

            promedio = (float)acumulador / 10;
            Console.WriteLine("El promedio es {0}", promedio);
            Console.WriteLine("El maximo es {0}", maximo);
            Console.WriteLine("El minimo es {0}", minimo);
            Console.ReadKey();

        }
    }
}
