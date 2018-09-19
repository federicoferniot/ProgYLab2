using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto(2, 0, Colores.Azul, 5000);
            Camion camion = new Camion(8, 2, Colores.Negro, 6, 2);
            Automovil auto = new Automovil(4, 2, Colores.Gris, 6, 5);
            Console.WriteLine("{0} {1} {2} {3}", moto.cantidadRuedas, moto.cantidadPuertas, moto.color, moto.cilindrada);
            Console.WriteLine("{0} {1} {2} {3} {4}", camion.cantidadRuedas, camion.cantidadPuertas, camion.color, camion.cantidadMarchas, camion.cantidadPasajeros);
            Console.WriteLine("{0} {1} {2} {3} {4}", auto.cantidadRuedas, auto.cantidadPuertas, auto.color, auto.cantidadMarchas, auto.cantidadPasajeros);
            Console.Read();
        }
    }
}
