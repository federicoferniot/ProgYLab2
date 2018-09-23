using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
	public enum TipoCompetencia
	{
		F1,
		MotoCross
	}

	class Competencia
	{
		private short cantidadCompetidores;
		private short cantidadVueltas;
		private List<VehiculoDeCarrera> competidores;
		private TipoCompetencia tipo;

		public short CantidadCompetidores
		{
			get { return this.cantidadCompetidores; }
			set { this.cantidadCompetidores = value; }
		}

		public short CantidadVueltas
		{
			get { return this.cantidadVueltas; }
			set { this.cantidadVueltas = value; }
		}

		public TipoCompetencia Tipo
		{
			get { return this.tipo; }
			set { this.tipo = value; }
		}

		private Competencia()
		{
			this.competidores = new List<VehiculoDeCarrera>();
		}

		public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
		{
			this.cantidadCompetidores = cantidadCompetidores;
			this.cantidadVueltas = cantidadVueltas;
			this.tipo = tipo;
		}

		public static bool operator +(Competencia competencia, VehiculoDeCarrera vehiculo)
		{
			if (competencia.competidores.Count < competencia.cantidadCompetidores)
			{
				if (competencia != vehiculo)
				{
					vehiculo.CantidadCombustible = (short)new Random(DateTime.Now.Millisecond).Next(15, 100);
					vehiculo.EnCompetencia = true;
					vehiculo.VueltasRestantes = competencia.cantidadVueltas;
					competencia.competidores.Add(vehiculo);
					return true;
				}
			}
			return false;
		}

		public string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Cantidad de vueltas: {0}\n", this.cantidadVueltas);
			foreach (VehiculoDeCarrera vehiculo in this.competidores)
				sb.AppendLine(vehiculo.MostrarDatos());
			return sb.ToString();
		}

		public static bool operator ==(Competencia competencia, VehiculoDeCarrera vehiculo)
		{
			foreach (VehiculoDeCarrera vehiculoCarrera in competencia.competidores)
			{
				if (vehiculo == vehiculoCarrera)
					return true;
			}
			return false;
		}

		public static bool operator !=(Competencia competencia, VehiculoDeCarrera auto)
		{
			return !(competencia == auto);
		}

	}
}
