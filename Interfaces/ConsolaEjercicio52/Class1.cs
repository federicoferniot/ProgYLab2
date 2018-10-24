using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesEjercicio52;

namespace ConsolaEjercicio52
{
    public class Class1
    {
        ConsoleColor colorOriginal = Console.ForegroundColor;
        Lapiz miLapiz = new Lapiz(10);
        Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
        EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
        Console.ForegroundColor = eLapiz.color;
        Console.WriteLine(eLapiz.texto);
        Console.ForegroundColor = colorOriginal;
        Console.WriteLine(miLapiz);
        EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
        Console.ForegroundColor = eBoligrafo.color;
        Console.WriteLine(eBoligrafo.texto);
        Console.ForegroundColor = colorOriginal;
        Console.WriteLine(miBoligrafo);
        Console.ReadKey();
    }
}
