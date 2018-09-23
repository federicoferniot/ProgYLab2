using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
	class Competencia
	{
		private short cantidadCompetidores;
		private short cantidadVueltas;
		private List<AutoF1> competidores;

		private Competencia()
		{
			this.competidores = new List<AutoF1>();
		}

		public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
		{
			this.cantidadCompetidores = cantidadCompetidores;
			this.cantidadVueltas = cantidadVueltas;
		}

		public static bool operator +(Competencia competencia, AutoF1 auto)
		{
			if (competencia.competidores.Count < competencia.cantidadCompetidores)
			{
				if (competencia != auto)
				{
					auto.CantidadCombustible = (short)new Random(DateTime.Now.Millisecond).Next(15, 100);
					auto.EnCompetencia = true;
					auto.VueltasRestantes = competencia.cantidadVueltas;
					competencia.competidores.Add(auto);
					return true;
				}
			}
			return false;
		}

		public string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Cantidad de vueltas: {0}\n", this.cantidadVueltas);
			foreach (AutoF1 auto in this.competidores)
				sb.AppendLine(auto.MostrarDatos());
			return sb.ToString();
		}

		public static bool operator ==(Competencia competencia, AutoF1 auto)
		{
			foreach (AutoF1 autoCompetencia in competencia.competidores)
			{
				if (auto == autoCompetencia)
					return true;
			}
			return false;
		}

		public static bool operator !=(Competencia competencia, AutoF1 auto)
		{
			return !(competencia == auto);
		}

	}
}
