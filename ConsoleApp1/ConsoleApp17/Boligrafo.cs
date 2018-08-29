using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            dibujo = "";
            return true;
        }

        public void Recargar()
        {
            this.SetTinta((short)(cantidadTintaMaxima - tinta));
        }

        private void SetTinta(short tinta)
        {
            short tintaAux;
            tintaAux = (short)(this.tinta + tinta);
            if(tintaAux>=0 && tintaAux<=cantidadTintaMaxima)
            {
                this.tinta = tintaAux;
            }
        }
    }
}
