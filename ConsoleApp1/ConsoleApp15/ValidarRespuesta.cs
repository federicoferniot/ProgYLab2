using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class ValidarRespuesta
    {
        public static bool ValidarS_N(char c)
        {
            if(Char.ToLower(c)=='s')
            {
                return true;
            }
            return false;
        }
    }
}
