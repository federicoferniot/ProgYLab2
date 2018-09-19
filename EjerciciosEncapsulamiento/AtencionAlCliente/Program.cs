using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio negocio = new Negocio("Supermercado");
            if(~negocio)
            {
                Console.WriteLine("Atendido");
            }
            else
            {
                Console.WriteLine("No atendido");
            }
            negocio.Cliente = new Cliente(123, "Cliente1");
            negocio.Cliente = new Cliente(123, "Cliente1");
            if (~negocio)
            {
                Console.WriteLine("Atendido");
            }
            else
            {
                Console.WriteLine("No atendido");
            }
            if (~negocio)
            {
                Console.WriteLine("Atendido");
            }
            else
            {
                Console.WriteLine("No atendido");
            }

            Console.ReadKey();
        }
    }
}
