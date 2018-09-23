using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
	public class Centralita
	{
		private List<Llamada> listaDeLlamadas;
		protected string razonSocial;

		public float GananciasPorLocal
		{
			get { return this.CalcularGanancia(TipoLlamada.Local); }
		}

		public float GananciasPorProvincial
		{
			get { return this.CalcularGanancia(TipoLlamada.Provincial); }
		}

		public float GananciasPorTotal
		{
			get { return this.CalcularGanancia(TipoLlamada.Todas); }
		}

		public List<Llamada> Llamadas
		{
			get { return this.listaDeLlamadas; }
		}

		private Centralita()
		{
			listaDeLlamadas = new List<Llamada>();
		}

		public Centralita(string nombreDeEmpresa): this()
		{
			this.razonSocial = nombreDeEmpresa;
		}

		private float CalcularGanancia(TipoLlamada tipo)
		{
			float total = 0;
			switch (tipo)
			{
				case TipoLlamada.Local:
					foreach (Llamada llamada in this.listaDeLlamadas)
					{
						if (llamada is Local)
							total += ((Local)llamada).CostoLlamada;
					}
					break;
				case TipoLlamada.Provincial:
					foreach (Llamada llamada in this.listaDeLlamadas)
					{
						if (llamada is Provincial)
							total += ((Provincial)llamada).CostoLlamada;
					}
					break;
				case TipoLlamada.Todas:
					foreach (Llamada llamada in this.listaDeLlamadas)
					{
						if (llamada is Local)
							total += ((Local)llamada).CostoLlamada;
						else if(llamada is Provincial)
							total += ((Provincial)llamada).CostoLlamada;
					}
					break;
			}
			return total;
		}

		public string Mostrar()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Razón Social: {0}\nGanancia Total: {1}\nGanancia por Locales: {2}\nGanancia por Provinciales: {3}\n",
				this.razonSocial, this.GananciasPorTotal, this.GananciasPorLocal, this.GananciasPorProvincial);
			foreach (Llamada llamada in this.listaDeLlamadas)
			{
				switch (llamada.GetType().ToString())
				{
					case ("CentralitaHerencia.Local"):
						sb.AppendLine(((Local)llamada).Mostrar());
						break;
					case ("CentralitaHerencia.Provincial"):
						sb.AppendLine(((Provincial)llamada).Mostrar());
						break;
				}
			}
			return sb.ToString();
		}

		public void OrdenarLlamadas()
		{
			this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
		}
	}
}
