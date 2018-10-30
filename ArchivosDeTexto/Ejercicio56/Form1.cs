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
            StreamReader streamReader = null;
            string fileName;
            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            { 
                fileName = abrirArchivo.FileName;
                try
                {
                    streamReader = new StreamReader(fileName);
                    this.rtbTexto.Text = streamReader.ReadToEnd();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    if(!(streamReader is null))
                        streamReader.Close();
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = null;
            string fileName;
            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                fileName = guardarArchivo.FileName;
                try
                {
                    streamWriter = new StreamWriter(fileName);
                    streamWriter.Write(this.rtbTexto.Text);
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    if (!(streamWriter is null))
                        streamWriter.Close();
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = null;
            if(abrirArchivo.FileName != "")
            {
                try
                {
                    streamWriter = new StreamWriter(abrirArchivo.FileName);
                    streamWriter.Write(this.rtbTexto.Text);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    if (!(streamWriter is null))
                        streamWriter.Close();
                }
            }
            else
            {
                this.guardarComoToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
