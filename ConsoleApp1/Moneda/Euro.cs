﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        private float cantidad;
        private static float cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 1/1.3642F;
        }

        public Euro(float cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(float cantidad, float cotizacion)
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

        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Euro euro)
        {
            return (Pesos)((Dolar)euro);
        }

        public static bool operator ==(Euro euroUno, Euro euroDos)
        {
            return euroUno.cantidad == euroDos.cantidad;
        }

        public static bool operator !=(Euro euroUno, Euro euroDos)
        {
            return !(euroUno == euroDos);
        }

        public static Euro operator +(Euro euroUno, Euro euroDos)
        {
            return new Euro(euroUno.GetCantidad() + euroDos.GetCantidad());
        }
    }
}
