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
    public partial class FrmAlumnos : Form
    {
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAlumno frmAlumno = new FrmAlumno();
            if(DialogResult.OK == frmAlumno.ShowDialog(this))
            {
                AlumnoDB alumnoDB = new AlumnoDB();
                Alumno alumnoAux = frmAlumno.Alumno;
                alumnoDB.Guardar(alumnoAux);
            }
        }
    }
}
