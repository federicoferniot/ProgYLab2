using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public enum EPuestoJerarquico
    {
        Administración,
        Gerencia,
        Sistemas,
        Accionista
    }

    public class Empleado
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private EPuestoJerarquico puesto;
        private int salario;

        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.puesto = puesto;
            this.salario = salario;
        }

        public static bool operator ==(Empleado empleadoUno, Empleado empleadoDos)
        {
            return (empleadoUno.legajo == empleadoDos.legajo);
        }

        public static bool operator !=(Empleado empleadoUno, Empleado empleadoDos)
        {
            return !(empleadoUno == empleadoDos);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("NOMBRE: {0}", this.nombre));
            sb.AppendLine(String.Format("APELLIDO: {0}", this.apellido));
            sb.AppendLine(String.Format("LEGAJO: {0}", this.legajo));
            sb.AppendLine(String.Format("SALARIO: {0}", this.salario));
            return sb.ToString();
        }

    }
}
