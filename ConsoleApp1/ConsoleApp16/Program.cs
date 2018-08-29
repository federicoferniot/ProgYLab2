using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";
            Alumno alumnoUno = new Alumno("Juan", "Perez", 310154);
            Alumno alumnoDos = new Alumno("Ana", "Gomez", 254868);
            Alumno alumnoTres = new Alumno("Daniela", "Martinez", 351568);

            alumnoUno.Estudiar(2, 6);
            alumnoDos.Estudiar(2, 1);
            alumnoTres.Estudiar(5, 8);

            alumnoUno.CalcularFinal();
            alumnoDos.CalcularFinal();
            alumnoTres.CalcularFinal();

            Console.WriteLine(alumnoUno.Mostrar());
            Console.WriteLine(alumnoDos.Mostrar());
            Console.WriteLine(alumnoTres.Mostrar());
            Console.ReadKey();
        }
    }
}
