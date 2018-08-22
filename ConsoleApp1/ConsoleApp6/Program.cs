using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";
            int año;
            string añoStr = "";

            while (!int.TryParse(añoStr, out año))
            {
                Console.WriteLine("Ingrese un año");
                añoStr = Console.ReadLine();
            }

            if (EsBisiesto(año))
            {
                Console.WriteLine("Es bisiesto");
            }
            else
            {
                Console.WriteLine("No es bisiesto");
            }
            Console.ReadKey();
        }

        static bool EsBisiesto(int año)
        {
            bool retorno = false;
            if((año%4==0) && !(año%100==0))
            {
                retorno = true;
            }
            else if((año%100==0) && (año%400==0))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
