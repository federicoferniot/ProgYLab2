using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Calculadora
    {
        public static double Calcular(double primerNumero, double segundoNumero, char operacion)
        {
            double resultado=0;
            switch(operacion)
            {
                case '+':
                    resultado = primerNumero + segundoNumero;
                    break;
                case '-':
                    resultado = primerNumero - segundoNumero;
                    break;
                case '*':
                    resultado = primerNumero * segundoNumero;
                    break;
                case '/':
                    if(Validar(segundoNumero))
                    {
                        resultado = primerNumero / segundoNumero;
                    }
                    break;
            }
            return resultado;
        }

        private static bool Validar(double numero)
        {
            if(numero !=0)
            {
                return true;
            }
            return false;
        }

    }
}
