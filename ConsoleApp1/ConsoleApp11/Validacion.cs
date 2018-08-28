using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Validacion
    {
        /// <summary>
        /// Valida si el valor está dentro del rango especificado
        /// </summary>
        /// <param name="valor">dato a validar</param>
        /// <param name="min">minimo del rango a validar</param>
        /// <param name="max">maximo del rango a validar</param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max)
        {
            if(valor>min && valor<max)
            {
                return true;
            }
            return false;
        }
    }
}
