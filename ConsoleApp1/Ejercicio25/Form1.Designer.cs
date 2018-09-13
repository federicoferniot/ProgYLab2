namespace Ejercicio25
{
    partial class Form1
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
            this.lblBinarioDecimal = new System.Windows.Forms.Label();
            this.lblDecimalBinario = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnBinarioDecimal = new System.Windows.Forms.Button();
            this.btnDecimalBinario = new System.Windows.Forms.Button();
            this.txtBinarioDecimal = new System.Windows.Forms.TextBox();
            this.txtDecimalBinario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBinarioDecimal
            // 
            this.lblBinarioDecimal.AutoSize = true;
            this.lblBinarioDecimal.Location = new System.Drawing.Point(13, 37);
            this.lblBinarioDecimal.Name = "lblBinarioDecimal";
            this.lblBinarioDecimal.Size = new System.Drawing.Size(89, 13);
            this.lblBinarioDecimal.TabIndex = 0;
            this.lblBinarioDecimal.Text = "Binario a Decimal";
            // 
            // lblDecimalBinario
            // 
            this.lblDecimalBinario.AutoSize = true;
            this.lblDecimalBinario.Location = new System.Drawing.Point(13, 87);
            this.lblDecimalBinario.Name = "lblDecimalBinario";
            this.lblDecimalBinario.Size = new System.Drawing.Size(89, 13);
            this.lblDecimalBinario.TabIndex = 1;
            this.lblDecimalBinario.Text = "Decimal a Binario";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(108, 34);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 20);
            this.txtBinario.TabIndex = 2;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(108, 84);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 3;
            // 
            // btnBinarioDecimal
            // 
            this.btnBinarioDecimal.Location = new System.Drawing.Point(214, 32);
            this.btnBinarioDecimal.Name = "btnBinarioDecimal";
            this.btnBinarioDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnBinarioDecimal.TabIndex = 4;
            this.btnBinarioDecimal.Text = "->";
            this.btnBinarioDecimal.UseVisualStyleBackColor = true;
            this.btnBinarioDecimal.Click += new System.EventHandler(this.btnBinarioDecimal_Click);
            // 
            // btnDecimalBinario
            // 
            this.btnDecimalBinario.Location = new System.Drawing.Point(214, 82);
            this.btnDecimalBinario.Name = "btnDecimalBinario";
            this.btnDecimalBinario.Size = new System.Drawing.Size(75, 23);
            this.btnDecimalBinario.TabIndex = 5;
            this.btnDecimalBinario.Text = "->";
            this.btnDecimalBinario.UseVisualStyleBackColor = true;
            this.btnDecimalBinario.Click += new System.EventHandler(this.btnDecimalBinario_Click);
            // 
            // txtBinarioDecimal
            // 
            this.txtBinarioDecimal.Enabled = false;
            this.txtBinarioDecimal.Location = new System.Drawing.Point(295, 34);
            this.txtBinarioDecimal.Name = "txtBinarioDecimal";
            this.txtBinarioDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtBinarioDecimal.TabIndex = 6;
            // 
            // txtDecimalBinario
            // 
            this.txtDecimalBinario.Enabled = false;
            this.txtDecimalBinario.Location = new System.Drawing.Point(295, 84);
            this.txtDecimalBinario.Name = "txtDecimalBinario";
            this.txtDecimalBinario.Size = new System.Drawing.Size(100, 20);
            this.txtDecimalBinario.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 139);
            this.Controls.Add(this.txtDecimalBinario);
            this.Controls.Add(this.txtBinarioDecimal);
            this.Controls.Add(this.btnDecimalBinario);
            this.Controls.Add(this.btnBinarioDecimal);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.lblDecimalBinario);
            this.Controls.Add(this.lblBinarioDecimal);
            this.Name = "Form1";
            this.Text = "Conversor Numérico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinarioDecimal;
        private System.Windows.Forms.Label lblDecimalBinario;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnBinarioDecimal;
        private System.Windows.Forms.Button btnDecimalBinario;
        private System.Windows.Forms.TextBox txtBinarioDecimal;
        private System.Windows.Forms.TextBox txtDecimalBinario;
    }
}

