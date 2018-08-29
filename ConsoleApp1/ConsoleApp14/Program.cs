using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Ejercicio_14
    {
        static void Main(string[] args)
        {
            string numeroStr;
            double numero1;
            double numero2;
            double resultado;
            Console.Title = "Ejercicio Nro 14";
            do
            {
                Console.WriteLine("Ingrese el lado del cuadrado");
                numeroStr = Console.ReadLine();
            } while (!double.TryParse(numeroStr, out numero1));
            resultado = CalculoDeArea.CalcularCuadrado(numero1);
            Console.WriteLine("El area del cuadrado es: {0}", resultado);

            do
            {
                Console.WriteLine("Ingrese la base del triangulo");
                numeroStr = Console.ReadLine();
            } while (!double.TryParse(numeroStr, out numero1));
            do
            {
                Console.WriteLine("Ingrese la altura del triangulo");
                numeroStr = Console.ReadLine();
            } while (!double.TryParse(numeroStr, out numero2));
            resultado = CalculoDeArea.CalcularTriangulo(numero1, numero2);
            Console.WriteLine("El area del triangulo es: {0}", resultado);

            do
            {
                Console.WriteLine("Ingrese el radio del circulo");
                numeroStr = Console.ReadLine();
            } while (!double.TryParse(numeroStr, out numero1));
            resultado = CalculoDeArea.CalcularCirculo(numero1);
            Console.WriteLine("El area del circulo es: {0}", resultado);

            Console.ReadKey();
        }
    }
}
