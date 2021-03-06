﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion)
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

        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.GetCantidad() * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar dolar)
        {
            return new Pesos(dolar.GetCantidad() * Pesos.GetCotizacion());
        }

        public static implicit operator Dolar(double numero)
        {
            return new Dolar(numero);
        }

        public static bool operator ==(Dolar dolarUno, Dolar dolarDos)
        {
            return dolarUno.cantidad == dolarDos.cantidad;
        }

        public static bool operator !=(Dolar dolarUno, Dolar dolarDos)
        {
            return !(dolarUno == dolarDos);
        }

        public static Dolar operator +(Dolar dolarUno, Dolar dolarDos)
        {
            return new Dolar(dolarUno.GetCantidad() + dolarDos.GetCantidad());
        }
    }
}
