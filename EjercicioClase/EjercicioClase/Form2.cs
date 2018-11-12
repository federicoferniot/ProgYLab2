using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase
{
    public partial class Form2 : Form
    {
        public delegate void Evento(string mensaje);

        public Form2()
        {
            InitializeComponent();
        }

        public void ManejadorEvento(string mensaje)
        {
            this.textBox1.Text = textBox1.Text + mensaje;
        }

    }
}
