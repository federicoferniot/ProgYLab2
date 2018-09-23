using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
	public class VehiculoDeCarrera
	{
		private short cantidadCombustible;
		private bool enCompetencia;
		private string escuderia;
		private short numero;
		private short vueltasRestantes;

		public short CantidadCombustible
		{
			get { return this.cantidadCombustible; }
			set { this.cantidadCombustible = value; }
		}

		public bool EnCompetencia
		{
			get { return this.enCompetencia; }
			set { this.enCompetencia = value; }
		}

		public short VueltasRestantes
		{
			get { return this.vueltasRestantes; }
			set { this.vueltasRestantes = value; }
		}

		public string Escuderia
		{
			get { return this.escuderia; }
			set { this.escuderia = value; }
		}

		public short Numero
		{
			get { return this.numero; }
			set { this.numero = value; }
		}

		public VehiculoDeCarrera(short numero, string escuderia)
		{
			this.numero = numero;
			this.escuderia = escuderia;
			this.cantidadCombustible = 0;
			this.enCompetencia = false;
			this.vueltasRestantes = 0;
		}

		public string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Numero: {0}\nEscuderia: {1}\nCantidad combustible {2}\n", this.numero, this.escuderia, this.cantidadCombustible);
			if (this.enCompetencia)
				sb.AppendFormat("Está en competencia. Vueltas restantes {0}", this.vueltasRestantes);
			else
				sb.AppendLine("No está en competencia");
			return sb.ToString();
		}

		public static bool operator ==(VehiculoDeCarrera vehiculoUno, VehiculoDeCarrera vehiculoDos)
		{
			return (vehiculoUno.numero == vehiculoDos.numero && vehiculoUno.escuderia == vehiculoDos.escuderia);
		}

		public static bool operator !=(VehiculoDeCarrera vehiculoUno, VehiculoDeCarrera vehiculoDos)
		{
			return !(vehiculoUno == vehiculoDos);
		}
	}
}
