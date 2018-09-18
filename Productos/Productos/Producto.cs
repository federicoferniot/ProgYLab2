using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Producto
    {
        private int identificador;
        private string nombre;
        private double precio;
        private double iva;
        public int Identificador
        {
            get
            {
                return this.identificador;
            }
            set
            {
                this.identificador = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public double Precio
        {
            set
            {
                this.precio = value;
                this.iva = precio * 0.21;
            }
        }

        public double Total
        {
            get
            {
                return precio + iva;
            }
        }

        public Producto(int identificador, string nombre, double precio, int cantidad)
        {
            this.Identificador = identificador;
            this.Nombre = nombre;
            this.Precio = precio;
        }
    }
}
