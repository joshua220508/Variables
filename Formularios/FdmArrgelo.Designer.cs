namespace Variables.Formularios
{
    partial class FdmArrgelo
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
            this.gpEdades = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.lbEdades = new System.Windows.Forms.ListBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.gpEdades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpEdades
            // 
            this.gpEdades.Controls.Add(this.lblMenor);
            this.gpEdades.Controls.Add(this.lblMayor);
            this.gpEdades.Controls.Add(this.lblPromedio);
            this.gpEdades.Controls.Add(this.lbEdades);
            this.gpEdades.Controls.Add(this.tbEdad);
            this.gpEdades.Controls.Add(this.label1);
            this.gpEdades.Location = new System.Drawing.Point(26, 46);
            this.gpEdades.Name = "gpEdades";
            this.gpEdades.Size = new System.Drawing.Size(178, 460);
            this.gpEdades.TabIndex = 0;
            this.gpEdades.TabStop = false;
            this.gpEdades.Text = "Edades: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar Edad";
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(28, 83);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(131, 26);
            this.tbEdad.TabIndex = 2;
            this.tbEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEdad_KeyDown);
            this.tbEdad.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbEdad_PreviewKeyDown);
            // 
            // lbEdades
            // 
            this.lbEdades.FormattingEnabled = true;
            this.lbEdades.ItemHeight = 20;
            this.lbEdades.Location = new System.Drawing.Point(35, 125);
            this.lbEdades.Name = "lbEdades";
            this.lbEdades.Size = new System.Drawing.Size(123, 204);
            this.lbEdades.TabIndex = 3;
            // 
            // lblPromedio
            // 
            this.lblPromedio.Location = new System.Drawing.Point(6, 338);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 23);
            this.lblPromedio.TabIndex = 4;
            this.lblPromedio.Text = "Promedio: 0";
            // 
            // lblMayor
            // 
            this.lblMayor.Location = new System.Drawing.Point(6, 372);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(100, 23);
            this.lblMayor.TabIndex = 5;
            this.lblMayor.Text = "Mayor: 0";
            this.lblMayor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMenor
            // 
            this.lblMenor.Location = new System.Drawing.Point(6, 411);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(100, 23);
            this.lblMenor.TabIndex = 6;
            this.lblMenor.Text = "Menor: 0";
            // 
            // FdmArrgelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 586);
            this.Controls.Add(this.gpEdades);
            this.MaximizeBox = false;
            this.Name = "FdmArrgelo";
            this.Text = "Arreglos";
            this.gpEdades.ResumeLayout(false);
            this.gpEdades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpEdades;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.ListBox lbEdades;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblMenor;
    }
}