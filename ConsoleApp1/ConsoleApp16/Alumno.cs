using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        public float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            Random random = new Random();
            if(nota1 >= 4 && nota2 >= 4)
            {
                notaFinal = random.Next(0, 10);
            }
            else
            {
                notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            nota1 = notaUno;
            nota2 = notaDos;
        }

        public string Mostrar()
        {
            string datosAlumno;
            datosAlumno = String.Format("Nombre y Apellido: {0} {1}\nLegajo {2}\nNota Uno: {3}\nNota Dos: {4}\n"
                , nombre, apellido, legajo, nota1, nota2);

            if(notaFinal!=-1)
            {
                datosAlumno = String.Concat(datosAlumno, String.Format("Nota Final: {0}\n", notaFinal));
            }
            else
            {
                datosAlumno = String.Concat(datosAlumno, "Alumno desaprobado\n");
            }
            return datosAlumno;
        }
    }
}
