using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Ejercicio_20
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 20";
            Console.WriteLine(Billetes.Euro.GetCotizacion());
            Console.WriteLine(Billetes.Pesos.GetCotizacion());
            Console.ReadKey();
        }
    }
}
