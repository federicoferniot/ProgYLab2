using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temporizador
{
    public sealed class Class1
    {
        public delegate void encargadoTiempo();

        private Thread hilo;
        private int intervalo;

        public bool Activo
        {
            get
            {
                return true;
            }
        }
        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

        private void Corriendo()
        {

        }

        public event encargadoTiempo EventoTiempo;
    }
}
