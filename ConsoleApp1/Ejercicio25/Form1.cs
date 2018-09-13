using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DecimalBinario;

namespace Ejercicio25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinarioDecimal_Click(object sender, EventArgs e)
        {
            if(txtBinario.Text != "")
            {
                txtBinarioDecimal.Text = Conversor.BinarioDecimal(txtBinario.Text).ToString();
            }
        }

        private void btnDecimalBinario_Click(object sender, EventArgs e)
        {
            if(txtDecimal.Text != "")
            {
                if(double.TryParse(txtDecimal.Text, out double numeroDecimal))
                {
                    txtDecimalBinario.Text = Conversor.DecimalBinario(numeroDecimal);
                }
            }
        }
    }
}
