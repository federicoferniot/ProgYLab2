using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
	public partial class frmContadorDePalabras : Form
	{
		public frmContadorDePalabras()
		{
			InitializeComponent();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder();
			string textoTotal = rtxtPalabras.Text;
			string[] palabrasSeparadas;
			Dictionary<string, int> contadorPalabras = new Dictionary<string, int>(); 
			textoTotal.Trim();
			palabrasSeparadas = textoTotal.Split(' ');
			foreach (string palabra in palabrasSeparadas)
			{
				if (contadorPalabras.ContainsKey(palabra))
				{
					contadorPalabras[palabra]++;
				}
				else
				{
					contadorPalabras.Add(palabra, 1);
				}
			}

			foreach (KeyValuePair<string, int> palabras in contadorPalabras)
			{
				sb.AppendLine(String.Format("{0} {1}", palabras.Key, palabras.Value));
			}

			rtxtPalabras.Text = sb.ToString();
		}
	}
}
