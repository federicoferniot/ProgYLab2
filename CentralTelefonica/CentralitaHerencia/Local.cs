﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
	public class Local: Llamada
	{
		protected float costo;

		public float CostoLlamada
		{
			get { return this.CalcularCosto(); }
		}

		public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
		{
			this.costo = costo;
		}

		public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
		{
			this.costo = costo;
		}

		private float CalcularCosto()
		{
			return this.costo * this.duracion;
		}

		public string Mostrar()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(base.Mostrar());
			sb.AppendFormat("Costo llamada: {0}", this.CostoLlamada);
			return sb.ToString();
		}
	}
}