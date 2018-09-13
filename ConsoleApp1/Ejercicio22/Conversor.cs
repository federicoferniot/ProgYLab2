using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalBinario
{
    public class Conversor
    {
        public static string DecimalBinario(double decim)
        {
            string binario="";
            if(decim==0)
            {
                binario = "0";
            }
            while(decim!=0)
            {
                binario = String.Concat((decim % 2).ToString(), binario);
                decim = (int)decim/2;
            }
            return binario;
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
