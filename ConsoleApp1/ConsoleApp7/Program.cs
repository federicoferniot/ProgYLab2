using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";
            double cantidadDias;
            int año=0;
            int mes=0;
            int dia=0;
            string añoStr="";
            string diaStr="";
            string mesStr="";

            while (!int.TryParse(añoStr, out año) || año<0)
            {
                Console.WriteLine("Ingrese el año de su fecha de nacimiento");
                añoStr = Console.ReadLine();
            }

            while (!int.TryParse(mesStr, out mes) || (mes<0 || mes>12))
            {
                Console.WriteLine("Ingrese el mes");
                mesStr = Console.ReadLine();
            }

            while (!int.TryParse(diaStr, out dia) || (dia<0 || dia>31))
            {
                Console.WriteLine("Ingrese el día");
                diaStr = Console.ReadLine();
            }

            DateTime fechaDeNacimiento = new DateTime(año, mes, dia);
            DateTime fechaActual = DateTime.Now;
            cantidadDias = (fechaActual - fechaDeNacimiento).TotalDays;
            Console.WriteLine("Cantidad de dias vividos: {0}", cantidadDias);
            Console.ReadKey();
        }
    }
}
