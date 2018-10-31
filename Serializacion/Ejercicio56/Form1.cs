using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio58;

namespace Ejercicio56
{
    public partial class frmEjercicio56 : Form
    {
        public frmEjercicio56()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.tslblCaracteres.Text = String.Format("{0} Caracteres", this.rtbTexto.Text.Length);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                fileName = abrirArchivo.FileName;
                switch (Path.GetExtension(fileName))
                {
                    case ".txt":
                        PuntoTxt archivoTxt = new PuntoTxt();
                        this.rtbTexto.Text = archivoTxt.Leer(fileName);
                        break;
                    case ".dat":
                        PuntoDat archivoDat = new PuntoDat();
                        archivoDat = archivoDat.Leer(fileName);
                        this.rtbTexto.Text = archivoDat.Contenido;
                        break;
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                fileName = this.guardarArchivo.FileName;
                switch(Path.GetExtension(fileName))
                {
                    case ".txt":
                        PuntoTxt archivoTxt = new PuntoTxt();
                        archivoTxt.Guardar(fileName, this.rtbTexto.Text);
                        break;
                    case ".dat":
                        PuntoDat archivoDat = new PuntoDat();
                        archivoDat.Contenido = this.rtbTexto.Text;
                        archivoDat.Guardar(fileName, archivoDat);
                        break;
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            if(abrirArchivo.FileName != "")
            {
                fileName = this.abrirArchivo.FileName;
                switch (Path.GetExtension(fileName))
                {
                    case ".txt":
                        PuntoTxt archivoTxt = new PuntoTxt();
                        archivoTxt.Guardar(fileName, this.rtbTexto.Text);
                        break;
                    case ".dat":
                        PuntoDat archivoDat = new PuntoDat();
                        archivoDat.Contenido = this.rtbTexto.Text;
                        archivoDat.Guardar(fileName, archivoDat);
                        break;
                }
            }
            else
            {
                this.guardarComoToolStripMenuItem_Click(sender, e);
            }
        }

        private void frmEjercicio56_Load(object sender, EventArgs e)
        {
            this.abrirArchivo.Filter = "Archivo Texto|*.txt|Archivo DAT|*.dat;*.bin";
            this.guardarArchivo.Filter = "Archivo Texto|*.txt|Archivo DAT|*.dat;*.bin";
        }
    }
}
