using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Conversor
    {
        public static string DecimalBinario(double decim)
        {
            double decimCopia = decim;
            return "";
            while(decimCopia!=0)
            {

            }
            
        }

        public static double BinarioDecimal(string binarioStr)
        {
            int exponencia = (int)Math.Pow(2, binarioStr.Length-1);
            double acumulador = 0;
            foreach(char caracter in binarioStr)
            {
                acumulador += ((int)Char.GetNumericValue(caracter)*exponencia);
                exponencia /= 2;
            }
            return acumulador;
        }
    }
}
