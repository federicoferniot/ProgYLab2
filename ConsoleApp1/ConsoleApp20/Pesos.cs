using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {

        private double cantidad;
        private static float cotizRespectoDolar;

        static Pesos()
        {
            cotizRespectoDolar = 17.55F;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static bool operator ==(Pesos pesosUno, Pesos pesosDos)
        {
            return pesosUno.cantidad == pesosDos.cantidad;
        }
        
        public static bool operator !=(Pesos pesosUno, Pesos pesosDos)
        {
            return !(pesosUno == pesosDos);
        }
    }
}
