using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
	public enum TipoLlamada
	{
		Local,
		Provincial,
		Todas
	}

	public abstract class Llamada
	{
		protected float duracion;
		protected string nroDestino;
		protected string nroOrigen;

        public abstract float CostoLlamada { get; }

		public float Duracion
		{
			get { return this.duracion; }
		}

		public string NroDestino
		{
			get { return this.nroDestino; }
		}

		public string NroOrigen
		{
			get { return this.nroOrigen; }
		}

		public Llamada(float duracion, string nroDestino, string nroOrigen)
		{
			this.duracion = duracion;
			this.nroDestino = nroDestino;
			this.nroOrigen = nroOrigen;
		}

		protected virtual string Mostrar()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Duracion: {0}\nNumero Destino: {1}\nNumero Origen: {2}", this.duracion, this.nroDestino, this.nroOrigen);
			return sb.ToString();
		}

		public static int OrdenarPorDuracion(Llamada llamadaUno, Llamada llamadaDos)
		{
			if (llamadaUno.duracion < llamadaDos.duracion)
				return -1;
			else if (llamadaUno.duracion > llamadaDos.duracion)
				return 1;
			return 0;
		}

        public static bool operator ==(Llamada llamadaUno, Llamada llamadaDos)
        {
            return (llamadaUno.Equals(llamadaDos)
                && llamadaUno.nroOrigen == llamadaDos.nroOrigen
                && llamadaUno.nroDestino == llamadaDos.nroDestino);
        }

        public static bool operator !=(Llamada llamadaUno, Llamada llamadaDos)
        {
            return !(llamadaUno == llamadaDos);
        }

	}
}
