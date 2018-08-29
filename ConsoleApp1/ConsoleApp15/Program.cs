using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";

            char respuesta;
            string numeroStr;
            double numeroUno;
            double numeroDos;
            char operacion;
            double resultado;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese el primer numero");
                    numeroStr = Console.ReadLine();
                } while (!double.TryParse(numeroStr, out numeroUno));
                do
                {
                    Console.WriteLine("Ingrese el segundo numero");
                    numeroStr = Console.ReadLine();
                } while (!double.TryParse(numeroStr, out numeroDos));
                Console.WriteLine("Ingrese la operacion a realizar(pulsando el caracter +, -, * ó /)");
                operacion = Console.ReadKey(true).KeyChar;

                resultado = Calculadora.Calcular(numeroUno, numeroDos, operacion);
                Console.WriteLine("El resultado es: {0:#,###.00}", resultado);
                Console.WriteLine("¿Continuar? (S/N)");
                respuesta = Console.ReadKey(true).KeyChar;
                Console.Clear();
            } while (ValidarRespuesta.ValidarS_N(respuesta));
            Console.ReadKey();
        }
    }
}
