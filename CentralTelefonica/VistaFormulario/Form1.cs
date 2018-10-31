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
    public partial class FrmCentralita : Form
    {
        private Centralita centralita;
        public FrmCentralita()
        {
            InitializeComponent();
        }

        private void FrmCentralita_Load(object sender, EventArgs e)
        {
            this.centralita = new Centralita("Central Telefónica");
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador =  new FrmLlamador(this.centralita);
            llamador.ShowDialog();
        }
    }
}
