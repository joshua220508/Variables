namespace Variables
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblVariableLocal = new System.Windows.Forms.Label();
            this.lblVariableGlobal = new System.Windows.Forms.Label();
            this.btnVerificarG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(246, 76);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(261, 26);
            this.tbNombre.TabIndex = 2;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(246, 153);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(136, 26);
            this.tbCodigo.TabIndex = 3;
            this.tbCodigo.TextChanged += new System.EventHandler(this.TbCodigo_TextChanged);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(46, 215);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(264, 80);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // lblVariableLocal
            // 
            this.lblVariableLocal.AutoSize = true;
            this.lblVariableLocal.Location = new System.Drawing.Point(136, 338);
            this.lblVariableLocal.Name = "lblVariableLocal";
            this.lblVariableLocal.Size = new System.Drawing.Size(109, 20);
            this.lblVariableLocal.TabIndex = 5;
            this.lblVariableLocal.Text = "Variable Local";
            this.lblVariableLocal.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblVariableGlobal
            // 
            this.lblVariableGlobal.AutoSize = true;
            this.lblVariableGlobal.Location = new System.Drawing.Point(140, 397);
            this.lblVariableGlobal.Name = "lblVariableGlobal";
            this.lblVariableGlobal.Size = new System.Drawing.Size(117, 20);
            this.lblVariableGlobal.TabIndex = 6;
            this.lblVariableGlobal.Text = "Variable Global";
            // 
            // btnVerificarG
            // 
            this.btnVerificarG.Location = new System.Drawing.Point(362, 215);
            this.btnVerificarG.Name = "btnVerificarG";
            this.btnVerificarG.Size = new System.Drawing.Size(210, 80);
            this.btnVerificarG.TabIndex = 7;
            this.btnVerificarG.Text = "Verificar Global";
            this.btnVerificarG.UseVisualStyleBackColor = true;
            this.btnVerificarG.Click += new System.EventHandler(this.btnVerificarG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 470);
            this.Controls.Add(this.btnVerificarG);
            this.Controls.Add(this.lblVariableGlobal);
            this.Controls.Add(this.lblVariableLocal);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblVariableLocal;
        private System.Windows.Forms.Label lblVariableGlobal;
        private System.Windows.Forms.Button btnVerificarG;
    }
}

