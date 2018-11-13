using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Alumnos
{
    public partial class FrmAlumno : Form
    {
        private Alumno alumno;

        public Alumno Alumno
        {
            get
            {
                return this.alumno;
            }
        }

        public FrmAlumno()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.alumno = new Alumno(txtNombre.Text, txtApellido.Text, txtDni.Text,
                dtpNacimiento.Value.Date, txtDireccion.Text);
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
