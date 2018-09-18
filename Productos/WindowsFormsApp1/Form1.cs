using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto(1, "Teclado", 800, 1);
            Producto producto2 = new Producto(2, "Mouse", 600, 1);
            Factura factura = new Factura(1252, DateTime.Now, Factura.Moneda.Dolar, Factura.TipoFactura.A);
            factura = factura + producto1;
            factura = factura + producto2;
            MessageBox.Show("Precio Total: " + factura.Total.ToString());
        }
    }
}
