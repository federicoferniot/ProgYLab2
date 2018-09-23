using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
	public class MotoCross: VehiculoDeCarrera
	{
		private short cilindrada;

		public short Cilindrada
		{
			get { return this.cilindrada; }
			set { this.cilindrada = value; }
		}

		public MotoCross(short numero, string escuderia): base(numero, escuderia)
		{
			this.cilindrada = 0;
		}

		public MotoCross(short numero, string escuderia, short cilindrada) : base(numero, escuderia)
		{
			this.cilindrada = cilindrada;
		}

		public static bool operator ==(MotoCross motoUno, MotoCross motoDos)
		{
			return ((VehiculoDeCarrera)motoUno == (VehiculoDeCarrera)motoDos && motoUno.Cilindrada == motoDos.Cilindrada);
		}

		public static bool operator !=(MotoCross motoUno, MotoCross motoDos)
		{
			return !(motoUno == motoDos);
		}
	}
}
