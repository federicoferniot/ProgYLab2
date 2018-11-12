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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLlenar form = new FormLlenar();
            form.Show(this);
            form.EnviarMensaje += this.NoHaceNada;
            foreach(Form x in this.OwnedForms)
            {
                if(x is Form2)
                {

                    form.EnviarMensaje += ((Form2)x).ManejadorEvento;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            foreach(Form x in this.OwnedForms)
            {
                if(x is FormLlenar)
                {
                    ((FormLlenar)x).EnviarMensaje += form2.ManejadorEvento;
                }
            }
            form2.Show(this);
        }

        public void NoHaceNada(string nada) { }
    }
}
