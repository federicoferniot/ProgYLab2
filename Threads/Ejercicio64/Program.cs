using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            List<String> clientes;
            Negocio negocio = new Negocio(caja1, caja2);
            Thread threadNegocio = new Thread(negocio.AsignarCaja);
            Thread threadCaja1 = new Thread(caja1.AtenderClientes);
            Thread threadCaja2 = new Thread(caja2.AtenderClientes);
            threadCaja1.Name = "Caja1";
            threadCaja2.Name = "Caja2";

            clientes = negocio.Clientes;
            clientes.Add("CLIENTE1");
            clientes.Add("Cliente2");
            clientes.Add("cLIENTE3");
            clientes.Add("cliente4");
            clientes.Add("cliente5");
            clientes.Add("cliente6");

            threadNegocio.Start();
            threadNegocio.Join();
            threadCaja1.Start();
            threadCaja2.Start();

            Console.ReadKey();
        }
    }
}
