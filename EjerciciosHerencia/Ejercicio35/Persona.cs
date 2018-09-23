using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
	public class Persona
	{
		private long dni;
		private string nombre;

		public long Dni
		{
			get { return this.dni; }
			set { this.dni = value; }
		}

		public string Nombre
		{
			get { return this.nombre; }
			set { this.nombre = value; }
		}

		public Persona(long dni, string nombre)
		{
			this.dni = dni;
			this.nombre = nombre;
		}

		public Persona(string nombre)
		{
			this.nombre = nombre;
		}

		public string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Dni: {0}\nNombre {1}", this.dni, this.nombre);
			return sb.ToString();
		}
	}
}
