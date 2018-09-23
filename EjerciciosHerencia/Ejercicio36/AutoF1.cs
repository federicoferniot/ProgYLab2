using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
	public class AutoF1: VehiculoDeCarrera
	{
		private short caballosDeFuerza;

		public short CaballosDeFuerza
		{
			get { return this.caballosDeFuerza; }
			set { this.caballosDeFuerza = value; }
		}

		public AutoF1(short numero, string escuderia): base(numero, escuderia)
		{
			caballosDeFuerza = 0;
		}

		public AutoF1(short numero, string escuderia, short caballosDeFuerza) : base(numero, escuderia)
		{
			this.caballosDeFuerza = caballosDeFuerza;
		}

		public static bool operator ==(AutoF1 autoUno, AutoF1 autoDos)
		{
			return ((VehiculoDeCarrera)autoUno == (VehiculoDeCarrera)autoDos && autoUno.CaballosDeFuerza == autoDos.CaballosDeFuerza);
		}

		public static bool operator !=(AutoF1 autoUno, AutoF1 autoDos)
		{
			return !(autoUno == autoDos);
		}
	}
}
