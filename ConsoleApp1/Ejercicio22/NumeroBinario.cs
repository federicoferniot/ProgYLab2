using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecimalBinario;

namespace Ejercicio22
{
    class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator string(NumeroBinario numero)
        {
            return numero.numero;
        }

        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            NumeroBinario binarioAuxiliar = Conversor.DecimalBinario(numeroDecimal + numeroBinario);
            return (string)binarioAuxiliar;
        }

        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            NumeroBinario binarioAuxiliar = Conversor.DecimalBinario(numeroDecimal - numeroBinario);
            return (string)binarioAuxiliar;
        }

        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return ((string)numeroBinario == Conversor.DecimalBinario((double)numeroDecimal));
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario == numeroDecimal);
        }
    }
}
