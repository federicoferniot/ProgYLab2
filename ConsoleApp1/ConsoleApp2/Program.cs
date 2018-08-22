using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";
            int numero;
            string numeroStr;

            Console.WriteLine("Ingrese un número");
            numeroStr = Console.ReadLine();
            while (!int.TryParse(numeroStr, out numero) || !(numero>0))
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                numeroStr = Console.ReadLine();
            }
            Console.WriteLine("El cuadrado es: {0}", Math.Pow(numero, 2));
            Console.WriteLine("El cubo es: {0}", Math.Pow(numero, 3));
            Console.ReadKey();
        }
    }
}
