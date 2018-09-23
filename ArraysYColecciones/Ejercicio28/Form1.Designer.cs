namespace Ejercicio28
{
	partial class frmContadorDePalabras
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rtxtPalabras = new System.Windows.Forms.RichTextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rtxtPalabras
			// 
			this.rtxtPalabras.Location = new System.Drawing.Point(12, 12);
			this.rtxtPalabras.Name = "rtxtPalabras";
			this.rtxtPalabras.Size = new System.Drawing.Size(776, 375);
			this.rtxtPalabras.TabIndex = 0;
			this.rtxtPalabras.Text = "";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(713, 393);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 1;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// frmContadorDePalabras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.rtxtPalabras);
			this.Name = "frmContadorDePalabras";
			this.Text = "Contador de palabras";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtxtPalabras;
		private System.Windows.Forms.Button btnCalcular;
	}
}

