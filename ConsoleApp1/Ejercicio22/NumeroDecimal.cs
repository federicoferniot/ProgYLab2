using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecimalBinario;

namespace Ejercicio22
{
    class NumeroDecimal
    {
        public double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator double(NumeroDecimal numero)
        {
            return numero.numero;
        }

        public static double operator +(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return (double)numeroDecimal + Conversor.BinarioDecimal((string)numeroBinario);
        }

        public static double operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return (double)numeroDecimal - Conversor.BinarioDecimal((string)numeroBinario);
        }

        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return ((double)numeroDecimal == Conversor.BinarioDecimal((string)numeroBinario));
        }

        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return !(numeroDecimal == numeroBinario);
        }
    }
}
