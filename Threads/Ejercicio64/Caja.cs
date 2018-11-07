using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio64
{
    class Caja
    {
        List<String> filaClientes;

        public List<String> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            foreach(String cliente in this.filaClientes)
            {
                Console.WriteLine("{0} {1}", cliente, Thread.CurrentThread.Name);
                Thread.Sleep(2000);
            }
        }
    }
}
