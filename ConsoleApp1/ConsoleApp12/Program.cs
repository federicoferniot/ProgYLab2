using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            string numeroStr;
            char respuesta;
            int numero;
            int acumulador = 0;
            Console.Title = "Ejercicio Nro 12";
            do
            {
                do
                {
                    Console.WriteLine("Ingrese el numero a sumar");
                    numeroStr = Console.ReadLine();
                } while (!int.TryParse(numeroStr, out numero));
                acumulador += numero;
                Console.WriteLine("¿Continuar? (S/N)");
                respuesta = Console.ReadKey(true).KeyChar;
            } while (ValidarRespuesta.ValidarS_N(respuesta));
            Console.WriteLine("La suma es {0}", acumulador);
            Console.ReadKey();
        }

    }
}
