using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";
            int contadorNumerosPerfectos = 0;
            int contador = 1;
            do
            {
                if(contador==SumarDivisoresDe(contador))
                {
                    Console.WriteLine(contador);
                    contadorNumerosPerfectos++;
                }
                contador++;
            } while (contadorNumerosPerfectos < 4);
            Console.ReadKey();
        }

        static int SumarDivisoresDe(int numero)
        {
            int acumulador = 0;
            for(int i=1; i<numero; i++)
            {
                if(numero%i==0)
                {
                    acumulador += i;
                }
            }
            return acumulador;
        }
    }
}
