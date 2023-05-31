namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioFerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioFerias));
            this.lblFerias = new System.Windows.Forms.Label();
            this.txtFerias = new System.Windows.Forms.TextBox();
            this.btnFerias = new System.Windows.Forms.Button();
            this.panelResultadoF = new System.Windows.Forms.Panel();
            this.lblResulatdoF = new System.Windows.Forms.Label();
            this.panelResultadoF.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFerias
            // 
            this.lblFerias.AutoSize = true;
            this.lblFerias.BackColor = System.Drawing.Color.Transparent;
            this.lblFerias.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFerias.Location = new System.Drawing.Point(32, 41);
            this.lblFerias.Name = "lblFerias";
            this.lblFerias.Size = new System.Drawing.Size(124, 30);
            this.lblFerias.TabIndex = 0;
            this.lblFerias.Text = "Salário Base";
            // 
            // txtFerias
            // 
            this.txtFerias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFerias.Location = new System.Drawing.Point(37, 85);
            this.txtFerias.Name = "txtFerias";
            this.txtFerias.Size = new System.Drawing.Size(119, 29);
            this.txtFerias.TabIndex = 1;
            // 
            // btnFerias
            // 
            this.btnFerias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFerias.Location = new System.Drawing.Point(37, 143);
            this.btnFerias.Name = "btnFerias";
            this.btnFerias.Size = new System.Drawing.Size(85, 32);
            this.btnFerias.TabIndex = 2;
            this.btnFerias.Text = "Calcular";
            this.btnFerias.UseVisualStyleBackColor = true;
            this.btnFerias.Click += new System.EventHandler(this.btnFerias_Click);
            // 
            // panelResultadoF
            // 
            this.panelResultadoF.Controls.Add(this.lblResulatdoF);
            this.panelResultadoF.Location = new System.Drawing.Point(13, 301);
            this.panelResultadoF.Name = "panelResultadoF";
            this.panelResultadoF.Size = new System.Drawing.Size(775, 137);
            this.panelResultadoF.TabIndex = 3;
            this.panelResultadoF.Visible = false;
            // 
            // lblResulatdoF
            // 
            this.lblResulatdoF.AutoSize = true;
            this.lblResulatdoF.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResulatdoF.Location = new System.Drawing.Point(340, 45);
            this.lblResulatdoF.Name = "lblResulatdoF";
            this.lblResulatdoF.Size = new System.Drawing.Size(68, 30);
            this.lblResulatdoF.TabIndex = 0;
            this.lblResulatdoF.Text = "label1";
            // 
            // frmBeneficioFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.ferias_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultadoF);
            this.Controls.Add(this.btnFerias);
            this.Controls.Add(this.txtFerias);
            this.Controls.Add(this.lblFerias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioFerias";
            this.Text = "FÉRIAS";
            this.panelResultadoF.ResumeLayout(false);
            this.panelResultadoF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFerias;
        private System.Windows.Forms.TextBox txtFerias;
        private System.Windows.Forms.Button btnFerias;
        private System.Windows.Forms.Panel panelResultadoF;
        private System.Windows.Forms.Label lblResulatdoF;
    }
}