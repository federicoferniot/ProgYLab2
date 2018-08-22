using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";
            int numero;
            string numeroStr="";
            while (!int.TryParse(numeroStr, out numero))
            {
                Console.WriteLine("Ingrese un número");
                numeroStr = Console.ReadLine();
            }
            for(int i=1;i<=numero;i++)
            {
                if(EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        static bool EsPrimo(int a)
        {
            for(int i=2; i<a; i++)
            {
                if(a%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
