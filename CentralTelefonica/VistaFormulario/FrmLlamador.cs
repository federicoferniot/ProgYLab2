using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace VistaFormulario
{
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        public FrmLlamador(Centralita centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "2";
        }
    }
}
