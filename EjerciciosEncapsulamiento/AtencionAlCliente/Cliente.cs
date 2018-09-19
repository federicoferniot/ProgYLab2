using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public Cliente(int numero)
        {
            Numero = numero;
        }

        public Cliente(int numero, string nombre): this(numero)
        {
            Nombre = nombre;
        }

        public static bool operator ==(Cliente clienteUno, Cliente clienteDos)
        {
            return (clienteUno.Numero == clienteDos.Numero);
        }

        public static bool operator !=(Cliente clienteUno, Cliente clienteDos)
        {
            return !(clienteUno == clienteDos);
        }
    }
}
