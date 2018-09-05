using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;
        /// <summary>
        /// Inicializa el array de productos con la capacidad dada.
        /// </summary>
        /// <param name="capacidad"></param>
        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        /// <summary>
        /// Inicializa una nueva instancia de la clase Estante con la capacidad y ubicación dada.
        /// </summary>
        /// <param name="capacidad">Capacidad del estante para agregar productos</param>
        /// <param name="ubicacion">Ubicación del estante</param>
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            ubicacionEstante = ubicacion;
        }
        /// <summary>
        /// Devuelve el array de productos del estante.
        /// </summary>
        /// <returns></returns>
        public Producto[] GetProductos()
        {
            return productos;
        }
        /// <summary>
        /// Devuelve la información del estante con la información de sus respectivos productos.
        /// </summary>
        /// <param name="estante"></param>
        /// <returns></returns>
        public static string MostrarEstante(Estante estante)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Ubicacion estante: {0}\n", estante.ubicacionEstante);
            for(int i=0; i<estante.productos.Length; i++)
            {
                if(!(estante.productos[i] is null))
                    sb.AppendLine(Producto.MostrarProducto(estante.productos[i]));
            }
            return sb.ToString();
        }
        /// <summary>
        /// Compara si existe el producto en el estante.
        /// </summary>
        /// <param name="estante"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator ==(Estante estante, Producto producto)
        {
            for(int i=0; i<estante.productos.Length; i++)
            {
                if (estante.productos[i] == producto)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }
        /// <summary>
        /// Agrega un producto al estante si hay un lugar vacio y si el producto no está en el estante
        /// </summary>
        /// <param name="estante"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator +(Estante estante, Producto producto)
        {
            int lugarLibre;
            if(estante.HayLugarLibre(out lugarLibre) && estante != producto)
            {
                estante.productos[lugarLibre] = producto;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Retira el producto del estante si es que se encuentra en él.
        /// </summary>
        /// <param name="estante"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static Estante operator -(Estante estante, Producto producto)
        {
            for(int i=0; i<estante.productos.Length; i++)
            {
                if(estante.productos[i] == producto)
                {
                    estante.productos[i] = null;
                    break;
                }
            }
            return estante;
        }
        /// <summary>
        /// Comprueba que haya un lugar libre en el estante
        /// </summary>
        /// <param name="lugarLibre">Devuelve [-1] si no hay lugar, sino la posicion libre</param>
        /// <returns>[true] si hay lugar [false] si no hay lugar</returns>
        private bool HayLugarLibre(out int lugarLibre)
        {
            lugarLibre = -1;
            for(int i=0; i<productos.Length; i++)
            {
                if(ReferenceEquals(productos[i], null))
                {
                    lugarLibre = i;
                    return true;
                }
            }
            return false;
        }
    }
}
