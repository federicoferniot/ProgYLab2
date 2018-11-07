using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio63
{
    public partial class Form1 : Form
    {
        DateTime fechaYHoraActual;
        Thread threadHora;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            threadHora = new Thread(new ParameterizedThreadStart(MetodoHora));
            threadHora.Start();

        }

        private void MetodoHora(Object o)
        {
            while(true)
            {
                this.fechaYHoraActual = DateTime.Now;
                this.AsignarHora();
                Thread.Sleep(1000);
            }
        }

        private void AsignarHora()
        {
            if (this.lblFechaYHora.InvokeRequired)
            {
                this.lblFechaYHora.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblFechaYHora.Text = this.fechaYHoraActual.ToString();
                }
                );
            }
            else
            {
                this.lblFechaYHora.Text = this.fechaYHoraActual.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
