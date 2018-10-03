namespace VistaForm
{
    partial class frmVista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDatosCurso = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtDocumentoProfe = new System.Windows.Forms.TextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblDocumentoProfe = new System.Windows.Forms.Label();
            this.lblApellidoProfe = new System.Windows.Forms.Label();
            this.lblNombreProfe = new System.Windows.Forms.Label();
            this.lblDivisionCurso = new System.Windows.Forms.Label();
            this.lblAnioCurso = new System.Windows.Forms.Label();
            this.gpbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.grbDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            this.gpbDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosCurso
            // 
            this.grbDatosCurso.Controls.Add(this.btnMostrar);
            this.grbDatosCurso.Controls.Add(this.btnCrear);
            this.grbDatosCurso.Controls.Add(this.dtpFechaIngreso);
            this.grbDatosCurso.Controls.Add(this.txtDocumentoProfe);
            this.grbDatosCurso.Controls.Add(this.txtApellidoProfe);
            this.grbDatosCurso.Controls.Add(this.txtNombreProfe);
            this.grbDatosCurso.Controls.Add(this.cmbDivisionCurso);
            this.grbDatosCurso.Controls.Add(this.nudAnioCurso);
            this.grbDatosCurso.Controls.Add(this.lblFechaIngreso);
            this.grbDatosCurso.Controls.Add(this.lblDocumentoProfe);
            this.grbDatosCurso.Controls.Add(this.lblApellidoProfe);
            this.grbDatosCurso.Controls.Add(this.lblNombreProfe);
            this.grbDatosCurso.Controls.Add(this.lblDivisionCurso);
            this.grbDatosCurso.Controls.Add(this.lblAnioCurso);
            this.grbDatosCurso.Location = new System.Drawing.Point(30, 36);
            this.grbDatosCurso.Name = "grbDatosCurso";
            this.grbDatosCurso.Size = new System.Drawing.Size(277, 252);
            this.grbDatosCurso.TabIndex = 0;
            this.grbDatosCurso.TabStop = false;
            this.grbDatosCurso.Text = "Datos Curso";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(170, 200);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(94, 39);
            this.btnMostrar.TabIndex = 13;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(9, 200);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(102, 39);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear Curso";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(64, 150);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 11;
            // 
            // txtDocumentoProfe
            // 
            this.txtDocumentoProfe.Location = new System.Drawing.Point(64, 124);
            this.txtDocumentoProfe.Name = "txtDocumentoProfe";
            this.txtDocumentoProfe.Size = new System.Drawing.Size(200, 20);
            this.txtDocumentoProfe.TabIndex = 10;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(64, 98);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(200, 20);
            this.txtApellidoProfe.TabIndex = 9;
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(64, 72);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(200, 20);
            this.txtNombreProfe.TabIndex = 8;
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(64, 45);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbDivisionCurso.TabIndex = 7;
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(64, 19);
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(120, 20);
            this.nudAnioCurso.TabIndex = 6;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(6, 156);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblFechaIngreso.TabIndex = 5;
            this.lblFechaIngreso.Text = "Ingreso";
            // 
            // lblDocumentoProfe
            // 
            this.lblDocumentoProfe.AutoSize = true;
            this.lblDocumentoProfe.Location = new System.Drawing.Point(6, 127);
            this.lblDocumentoProfe.Name = "lblDocumentoProfe";
            this.lblDocumentoProfe.Size = new System.Drawing.Size(26, 13);
            this.lblDocumentoProfe.TabIndex = 4;
            this.lblDocumentoProfe.Text = "DNI";
            // 
            // lblApellidoProfe
            // 
            this.lblApellidoProfe.AutoSize = true;
            this.lblApellidoProfe.Location = new System.Drawing.Point(6, 101);
            this.lblApellidoProfe.Name = "lblApellidoProfe";
            this.lblApellidoProfe.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoProfe.TabIndex = 3;
            this.lblApellidoProfe.Text = "Apellido";
            // 
            // lblNombreProfe
            // 
            this.lblNombreProfe.AutoSize = true;
            this.lblNombreProfe.Location = new System.Drawing.Point(6, 75);
            this.lblNombreProfe.Name = "lblNombreProfe";
            this.lblNombreProfe.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProfe.TabIndex = 2;
            this.lblNombreProfe.Text = "Nombre";
            // 
            // lblDivisionCurso
            // 
            this.lblDivisionCurso.AutoSize = true;
            this.lblDivisionCurso.Location = new System.Drawing.Point(6, 48);
            this.lblDivisionCurso.Name = "lblDivisionCurso";
            this.lblDivisionCurso.Size = new System.Drawing.Size(44, 13);
            this.lblDivisionCurso.TabIndex = 1;
            this.lblDivisionCurso.Text = "División";
            // 
            // lblAnioCurso
            // 
            this.lblAnioCurso.AutoSize = true;
            this.lblAnioCurso.Location = new System.Drawing.Point(6, 21);
            this.lblAnioCurso.Name = "lblAnioCurso";
            this.lblAnioCurso.Size = new System.Drawing.Size(26, 13);
            this.lblAnioCurso.TabIndex = 0;
            this.lblAnioCurso.Text = "Año";
            // 
            // gpbDatosAlumno
            // 
            this.gpbDatosAlumno.Controls.Add(this.btnAgregar);
            this.gpbDatosAlumno.Controls.Add(this.cmbDivision);
            this.gpbDatosAlumno.Controls.Add(this.nudAnio);
            this.gpbDatosAlumno.Controls.Add(this.txtDocumento);
            this.gpbDatosAlumno.Controls.Add(this.txtApellido);
            this.gpbDatosAlumno.Controls.Add(this.txtNombre);
            this.gpbDatosAlumno.Controls.Add(this.lblDivision);
            this.gpbDatosAlumno.Controls.Add(this.lblAnio);
            this.gpbDatosAlumno.Controls.Add(this.lblDocumento);
            this.gpbDatosAlumno.Controls.Add(this.lblApellido);
            this.gpbDatosAlumno.Controls.Add(this.lblNombre);
            this.gpbDatosAlumno.Location = new System.Drawing.Point(313, 36);
            this.gpbDatosAlumno.Name = "gpbDatosAlumno";
            this.gpbDatosAlumno.Size = new System.Drawing.Size(258, 252);
            this.gpbDatosAlumno.TabIndex = 1;
            this.gpbDatosAlumno.TabStop = false;
            this.gpbDatosAlumno.Text = "Datos Alumno";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(163, 200);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 39);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(78, 123);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(121, 21);
            this.cmbDivision.TabIndex = 9;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(78, 97);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(120, 20);
            this.nudAnio.TabIndex = 8;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(78, 71);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(166, 20);
            this.txtDocumento.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(78, 45);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(166, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(6, 126);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 4;
            this.lblDivision.Text = "División";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(6, 99);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "Año";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(6, 74);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(39, 13);
            this.lblDocumento.TabIndex = 2;
            this.lblDocumento.Text = "Legajo";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 48);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(0, 294);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(581, 215);
            this.rtbDatos.TabIndex = 2;
            this.rtbDatos.Text = "";
            // 
            // frmVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 509);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.gpbDatosAlumno);
            this.Controls.Add(this.grbDatosCurso);
            this.Name = "frmVista";
            this.Text = "Vista del curso";
            this.Load += new System.EventHandler(this.frmVista_Load);
            this.grbDatosCurso.ResumeLayout(false);
            this.grbDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            this.gpbDatosAlumno.ResumeLayout(false);
            this.gpbDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosCurso;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox txtDocumentoProfe;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.NumericUpDown nudAnioCurso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblDocumentoProfe;
        private System.Windows.Forms.Label lblApellidoProfe;
        private System.Windows.Forms.Label lblNombreProfe;
        private System.Windows.Forms.Label lblDivisionCurso;
        private System.Windows.Forms.Label lblAnioCurso;
        private System.Windows.Forms.GroupBox gpbDatosAlumno;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RichTextBox rtbDatos;
    }
}

