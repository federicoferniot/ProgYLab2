using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public static double CalcularTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        public static double CalcularCirculo(double radio)
        {
            return Math.Pow(radio, 2) * Math.PI;
        }
    }
}
