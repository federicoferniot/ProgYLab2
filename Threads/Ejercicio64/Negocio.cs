using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio64
{
    class Negocio
    {
        List<String> clientes;
        Caja cajaUno;
        Caja cajaDos;

        public Caja Caja1
        {
            get
            {
                return this.cajaUno;
            }
        }
        public Caja Caja2
        {
            get
            {
                return this.cajaDos;
            }
        }
        public List<String> Clientes
        {
            get
            {
                return this.clientes;
            }
        }

        public Negocio(Caja cajaUno, Caja cajaDos)
        {
            this.clientes = new List<string>();
            this.cajaUno = cajaUno;
            this.cajaDos = cajaDos;
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");
            foreach(String cliente in this.clientes)
            {
                if (this.cajaUno.FilaClientes.Count <= this.cajaDos.FilaClientes.Count)
                    this.cajaUno.FilaClientes.Add(cliente);
                else
                    this.cajaDos.FilaClientes.Add(cliente);
                Thread.Sleep(1000);
            }

        }
    }
}
