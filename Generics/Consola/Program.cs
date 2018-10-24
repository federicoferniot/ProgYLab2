using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo de futbol");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo de basquet");
            EquipoFutbol equipoFutbolUno = new EquipoFutbol("Futbol Uno", DateTime.Now);
            EquipoFutbol equipoFutbolDos = new EquipoFutbol("Futbol Dos", DateTime.Now);
            EquipoFutbol equipoFutbolTres = new EquipoFutbol("Futbol Tres", DateTime.Now);

            EquipoBasquet equipoBasquetUno = new EquipoBasquet("Basquet Uno", DateTime.Now);
            EquipoBasquet equipoBasquetDos = new EquipoBasquet("Basquet Dos", DateTime.Now);
            EquipoBasquet equipoBasquetTres = new EquipoBasquet("Basquet Tres", DateTime.Now);

            torneoFutbol += equipoFutbolUno;
            torneoFutbol += equipoFutbolDos;
            torneoFutbol += equipoFutbolTres;

            torneoBasquet += equipoBasquetUno;
            torneoBasquet += equipoBasquetDos;
            torneoBasquet += equipoBasquetTres;

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoBasquet.Mostrar());

            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.ReadKey();
        }
    }
}
