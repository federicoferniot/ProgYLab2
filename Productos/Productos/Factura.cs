using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Productos
{
    public class Factura
    {
        public enum TipoFactura
        {
            A,
            B,
            C
        }

        public enum Moneda
        {
            Dolar,
            Pesos,
            Euro
        }

        private TipoFactura tipo;
        private int numero;
        private DateTime fecha;
        private Moneda moneda;
        private List<Producto> productos;

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        public TipoFactura Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public double Total
        {
            get
            {
                double resultado = 0;
                foreach (Producto producto in productos)
                {
                    resultado += producto.Total;
                }
                switch(moneda)
                {
                    case Moneda.Pesos:
                        resultado = new Pesos(resultado).GetCantidad();
                        break;
                    case Moneda.Dolar:
                        resultado = ((Pesos)new Dolar(resultado)).GetCantidad();
                        break;
                    case Moneda.Euro:
                        resultado = ((Pesos)new Euro(resultado)).GetCantidad();
                        break;
                }
                return resultado;
            }
        }

        public Producto this[int identificador]
        {
            get
            {
                foreach(Producto producto in this.productos)
                {
                    if(identificador == producto.Identificador)
                    {
                        return producto;
                    }
                }
                return null;
            }
            set
            {
                bool encontro = false;
                foreach(Producto producto in this.productos)
                {
                    if(producto.Identificador == identificador)
                    {
                        this.productos[this.productos.IndexOf(producto)] = value;
                        encontro = true;
                    }
                }
                if(!encontro)
                {
                    this.productos.Add(value);
                }
            }
        }

        public Factura(int numero, DateTime fecha, Moneda moneda, TipoFactura tipoFactura)
        {
            this.numero = numero;
            this.fecha = fecha;
            this.moneda = moneda;
            this.tipo = tipoFactura;
            this.productos = new List<Producto>();
        }

        public static Factura operator +(Factura factura, Producto producto)
        {
            factura.productos.Add(producto);
            return factura;
        }

        public static Factura operator -(Factura factura, Producto producto)
        {
            factura.productos.Remove(producto);
            return factura;
        }
    }
}
