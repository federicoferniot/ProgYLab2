using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
	public class DirectorTecnico : Persona
	{
		private DateTime fechaNacimiento;

		private DirectorTecnico(string nombre) : base(nombre)
		{
			this.fechaNacimiento = DateTime.Now;
		}

		public DateTime FechaNacimiento
		{
			get { return this.fechaNacimiento; }
			set { this.fechaNacimiento = value; }
		}

		public DirectorTecnico(string nombre, DateTime fechaNacimiento): base(nombre)
		{
			this.fechaNacimiento = fechaNacimiento;
		}

		public new string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(base.MostrarDatos());
			sb.AppendFormat("Fecha nacimiento: {0}", this.fechaNacimiento);
			return sb.ToString();
		}

		public static bool operator ==(DirectorTecnico directorUno, DirectorTecnico directorDos)
		{
			return (directorUno.Nombre == directorDos.Nombre && directorUno.fechaNacimiento == directorDos.fechaNacimiento);
		}

		public static bool operator !=(DirectorTecnico directorUno, DirectorTecnico directorDos)
		{
			return !(directorUno != directorDos);
		}

	}
}
