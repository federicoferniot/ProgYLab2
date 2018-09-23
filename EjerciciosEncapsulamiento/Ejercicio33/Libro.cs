using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
	public class Libro
	{
		private List<string> paginas;

		public Libro()
		{
			this.paginas = new List<string>();
		}

		public string this[int i]
		{
			get
			{
				if (i < this.paginas.Count)
					return this.paginas[i];
				return "";
			}
			set
			{
				if (i < this.paginas.Count)
					this.paginas[i] = value;
				else
					this.paginas.Add(value);
			}
		}
	}
}
