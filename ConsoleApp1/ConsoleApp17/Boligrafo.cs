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
            SetTinta(tinta);
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
        /// <summary>
        /// Gasta tanta tinta como pueda, devolviendo si pudo o no dibujar.
        /// </summary>
        /// <param name="gasto">Cantidad de tinta a gastar</param>
        /// <param name="dibujo">Si pudo dibujar, devuelve tantos '*' como lo que pudo gastar de tinta</param>
        /// <returns></returns>
        public bool Pintar(int gasto, out string dibujo)
        {
            StringBuilder sb = new StringBuilder();
            short tintaAGastar;
            if(GetTinta()!=0)
            {
                if(GetTinta()<gasto)
                {
                    tintaAGastar = GetTinta();
                }
                else
                {
                    tintaAGastar = (short)gasto;
                }
                SetTinta((short)-gasto);
                sb.Append('*', tintaAGastar);
                dibujo = sb.ToString();
                return true;
            }
            else
            {
                dibujo = "";
                return false;
            }
        }
        /// <summary>
        /// Recarga la tinta a su capacidad maxima
        /// </summary>
        public void Recargar()
        {
            SetTinta((short)(cantidadTintaMaxima - tinta));
        }

        private void SetTinta(short tinta)
        {
            short tintaAux;
            tintaAux = (short)(this.tinta + tinta);
            if(tintaAux<=0)
            {
                this.tinta = 0;
            }
            else if(tintaAux>=cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else
            {
                this.tinta = tintaAux;
            }
        }
    }
}
