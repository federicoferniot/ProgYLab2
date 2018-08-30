using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujo;
            Console.Title = "Ejercicio Nro 17";
            Boligrafo boligrafoUno = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoDos = new Boligrafo(50, ConsoleColor.Red);
            Console.ForegroundColor = boligrafoUno.GetColor();
            if(boligrafoUno.Pintar(60, out dibujo))
            {
                Console.ForegroundColor = boligrafoUno.GetColor();
                Console.WriteLine(dibujo);
                Console.ResetColor();
            }
            if (boligrafoDos.Pintar(60, out dibujo))
            {
                Console.ForegroundColor = boligrafoDos.GetColor();
                Console.WriteLine(dibujo);
                Console.ResetColor();
            }
            if (boligrafoDos.Pintar(60, out dibujo))
            {
                Console.ForegroundColor = boligrafoDos.GetColor();
                Console.WriteLine(dibujo);
                Console.ResetColor();
            }
            boligrafoDos.Recargar();
            if (boligrafoDos.Pintar(60, out dibujo))
            {
                Console.ForegroundColor = boligrafoDos.GetColor();
                Console.WriteLine(dibujo);
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}
