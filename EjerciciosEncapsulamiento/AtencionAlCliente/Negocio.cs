using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                if(this.ClientesPendientes > 0)
                    return clientes.Dequeue();
                return null;
            }
            set
            {
                bool encolado = this + value;
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre): this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            bool encontrado = false;
            foreach(Cliente clienteNegocio in negocio.clientes)
            {
                if(cliente == clienteNegocio)
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);
        }

        public static bool operator +(Negocio negocio, Cliente cliente)
        {
            bool encolado = false;
            if(negocio != cliente)
            {
                negocio.clientes.Enqueue(cliente);
                encolado = true;
            }
            return encolado;
        }

        public static bool operator ~(Negocio negocio)
        {
            Cliente cliente = negocio.Cliente;
            if (cliente is null)
                return false;
            return negocio.caja.AtenderCliente(negocio.Cliente);
        }
    }
}
