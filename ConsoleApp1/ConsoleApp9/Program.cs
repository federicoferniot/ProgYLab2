using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 09";
            int nivelPiramide;
            string caracterADibujar;
            string nivelPiramideStr="";

            while (!int.TryParse(nivelPiramideStr, out nivelPiramide) || nivelPiramide < 0)
            {
                Console.WriteLine("Ingrese el nivel de la piramide");
                nivelPiramideStr = Console.ReadLine();
            }

            for (int i = 0, cantidadEnNivel = 1; i < nivelPiramide; i++,cantidadEnNivel+=2)
            {
                caracterADibujar = new String('*', cantidadEnNivel);
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (caracterADibujar.Length / 2)) + "}", caracterADibujar));
            }
            Console.ReadKey();
        }
    }
}
