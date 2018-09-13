using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            Euro monedaOriginal;
            float doubleMoneda =0;
            if(txtEuro.Text != "")
            {
                if(float.TryParse(txtEuro.Text, out doubleMoneda))
                {
                    monedaOriginal = new Euro(doubleMoneda);
                    this.txtEuroEuro.Text = (monedaOriginal.GetCantidad()).ToString();
                    this.txtEuroDolar.Text = (((Dolar)monedaOriginal).GetCantidad()).ToString();
                    this.txtEuroPesos.Text = (((Pesos)monedaOriginal).GetCantidad()).ToString();
                }
            }
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            Dolar monedaOriginal;
            float doubleMoneda = 0;
            if (txtDolar.Text != "")
            {
                if (float.TryParse(txtDolar.Text, out doubleMoneda))
                {
                    monedaOriginal = new Dolar(doubleMoneda);
                    this.txtDolarEuro.Text = (((Euro)monedaOriginal).GetCantidad()).ToString();
                    this.txtDolarDolar.Text = (monedaOriginal.GetCantidad()).ToString();
                    this.txtDolarPesos.Text = (((Pesos)monedaOriginal).GetCantidad()).ToString();
                }
            }
        }

        private void btnPesos_Click(object sender, EventArgs e)
        {
            Pesos monedaOriginal;
            float doubleMoneda = 0;
            if (txtPesos.Text != "")
            {
                if (float.TryParse(txtPesos.Text, out doubleMoneda))
                {
                    monedaOriginal = new Pesos(doubleMoneda);
                    this.txtPesosEuro.Text = (((Euro)monedaOriginal).GetCantidad()).ToString();
                    this.txtPesosDolar.Text = (((Dolar)monedaOriginal).GetCantidad()).ToString();
                    this.txtPesosPesos.Text = (monedaOriginal.GetCantidad()).ToString();
                }
            }
        }
    }
}
