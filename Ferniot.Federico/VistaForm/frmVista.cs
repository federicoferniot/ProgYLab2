using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class frmVista : Form
    {
        private Curso curso;

        public frmVista()
        {
            InitializeComponent();
        }

        private void frmVista_Load(object sender, EventArgs e)
        {
            this.cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            this.cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(!(this.curso is null))
            {
                this.rtbDatos.Text = (string)this.curso;
            }
            else
            {
                MessageBox.Show("No se creó un curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Profesor profesorAuxiliar;
            if (!Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division))
                return;
            if (this.txtNombreProfe.Text.Trim() == "")
                return;
            if (this.txtApellidoProfe.Text.Trim() == "")
                return;
            if (this.txtDocumentoProfe.Text.Trim() == "")
                return;
            profesorAuxiliar = new Profesor(txtNombreProfe.Text.Trim(),
                txtApellidoProfe.Text.Trim(), txtDocumentoProfe.Text.Trim(), this.dtpFechaIngreso.Value);
            this.curso = new Curso((short)this.nudAnioCurso.Value, division, profesorAuxiliar);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            if (!(this.curso is null))
            {
                if(txtNombre.Text.Trim() == "")
                    return;
                if (txtApellido.Text.Trim() == "")
                    return;
                if (txtDocumento.Text.Trim() == "")
                    return;
                if (!(Enum.TryParse<Divisiones>(cmbDivision.SelectedValue.ToString(), out division)))
                    return;
                this.curso += new Alumno(txtNombre.Text.Trim(), txtApellido.Text.Trim(),
                    txtDocumento.Text.Trim(), (short)nudAnio.Value, division);
            }
        }
    }
}
