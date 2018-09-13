using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Pesos
    {

        private float cantidad;
        private static float cotizRespectoDolar;

        static Pesos()
        {
            cotizRespectoDolar = 17.55F;
        }

        public Pesos(float cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(float cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = cotizacion;
        }

        public float GetCantidad()
        {
            return cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Dolar(Pesos pesos)
        {
            return new Dolar(pesos.GetCantidad() / Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos pesos)
        {
            return (Euro)(Dolar)pesos;
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
