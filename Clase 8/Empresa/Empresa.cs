using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Empresa
    {
        private List<Empleado> nominaEmpleados;
        private string razonSocial;
        private string direccion;
        private float ganancias;
        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
            set
            {
                this.razonSocial = value;
            }
        }

        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }

        public float Ganancias
        {
            get
            {
                return this.ganancias;
            }
            set
            {
                this.ganancias = value;
            }
        }

        private Empresa()
        {
            this.nominaEmpleados = new List<Empleado>();
        }

        public Empresa(string razonSocial, string direccion, float ganancias): this()
        {
            RazonSocial = razonSocial;
            Direccion = direccion;
            Ganancias = ganancias;
        }

        public static Empresa operator +(Empresa empresa, Empleado empleado)
        {
            bool encontrado = false;
            foreach(Empleado empleadoEmpresa in empresa.nominaEmpleados)
            {
                if(empleado == empleadoEmpresa)
                {
                    encontrado = true;
                }
            }
            if(!encontrado)
            {
                empresa.nominaEmpleados.Add(empleado);
            }
            return empresa;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("La empresa {0} sita en la calle {1} cuenta con ganancias por {2} y con {3} empleados:",
                this.razonSocial, this.direccion, this.ganancias, this.nominaEmpleados.Count));
            foreach(Empleado empleado in this.nominaEmpleados)
            {
                sb.AppendLine(empleado.Mostrar());
            }
            return sb.ToString();
        }

    }
}
