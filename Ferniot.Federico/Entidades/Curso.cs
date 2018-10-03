using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string AnioDivision
        {
            get
            {
                return String.Format("{0}º{1}", this.anio, this.division.ToString());
            }
        }

        #region Constructores

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor): this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        #endregion

        #region Operadores

        public static explicit operator string(Curso curso)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Curso: {0}\n", curso.AnioDivision);
            sb.AppendLine("Profesor:");
            sb.Append(curso.profesor.ExponerDatos());
            sb.AppendLine("Alumnos:");
            foreach(Alumno alumno in curso.alumnos)
            {
                sb.Append(alumno.ExponerDatos());
            }

            return sb.ToString();
        }

        public static bool operator ==(Curso curso, Alumno alumno)
        {
            return (curso.AnioDivision == alumno.AnioDivision);
        }

        public static bool operator !=(Curso curso, Alumno alumno)
        {
            return !(curso == alumno);
        }

        public static Curso operator +(Curso curso, Alumno alumno)
        {
            if(curso == alumno)
            {
                curso.alumnos.Add(alumno);
            }
            return curso;
        }

        #endregion
    }
}
