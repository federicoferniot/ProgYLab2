using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        protected string codigoDeBarra;
        protected string marca;
        protected float precio;
        /// <summary>
        /// Inicializa una nueva instancia de la clase Producto con la marca, codigo y precio dado.
        /// </summary>
        /// <param name="marca">Marca del producto</param>
        /// <param name="codigo">Codigo de barra del producto</param>
        /// <param name="precio">Precio del producto</param>
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            codigoDeBarra = codigo;
            this.precio = precio;
        }
        /// <summary>
        /// Devuelve la marca del producto.
        /// </summary>
        /// <returns></returns>
        public string GetMarca()
        {
            return marca;
        }
        /// <summary>
        /// Devuelve el precio del producto.
        /// </summary>
        /// <returns></returns>
        public float GetPrecio()
        {
            return precio;
        }
        /// <summary>
        /// Devuelve la información del producto
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static string MostrarProducto(Producto producto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} ", producto.GetMarca());
            sb.AppendFormat("{0} ", producto.codigoDeBarra);
            sb.AppendFormat("{0}", producto.GetPrecio());
            return sb.ToString();
        }

        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarra;
        }
        /// <summary>
        /// Compara si un producto es igual a otro. Es igual en el caso que tengan la misma marca y codigo de barra.
        /// </summary>
        /// <param name="productoUno"></param>
        /// <param name="productoDos"></param>
        /// <returns></returns>
        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            if(!(productoUno is null) && !(productoDos is null))
                return ((productoUno.GetMarca()==productoDos.GetMarca()) && (productoUno.codigoDeBarra == productoDos.codigoDeBarra));
            return false;
        }
        /// <summary>
        /// Compara un producto con una marca. Son iguales si la marca es la misma que la del producto
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator ==(Producto producto, string marca)
        {
            return (producto.GetMarca() == marca);
        }

        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno == productoDos);
        }

        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto == marca);
        }
    }
}
