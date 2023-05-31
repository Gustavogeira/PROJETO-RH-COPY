namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioSeguroDesemprego));
            this.lblSalario1 = new System.Windows.Forms.Label();
            this.txtSalario1 = new System.Windows.Forms.TextBox();
            this.btnSeguroDesemprego = new System.Windows.Forms.Button();
            this.panelResulatdoS = new System.Windows.Forms.Panel();
            this.lblResultadoS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelResulatdoS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario1
            // 
            this.lblSalario1.AutoSize = true;
            this.lblSalario1.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario1.ForeColor = System.Drawing.Color.Black;
            this.lblSalario1.Location = new System.Drawing.Point(50, 48);
            this.lblSalario1.Name = "lblSalario1";
            this.lblSalario1.Size = new System.Drawing.Size(124, 30);
            this.lblSalario1.TabIndex = 0;
            this.lblSalario1.Text = "Salário Base";
            // 
            // txtSalario1
            // 
            this.txtSalario1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario1.Location = new System.Drawing.Point(46, 103);
            this.txtSalario1.Name = "txtSalario1";
            this.txtSalario1.Size = new System.Drawing.Size(119, 29);
            this.txtSalario1.TabIndex = 1;
            // 
            // btnSeguroDesemprego
            // 
            this.btnSeguroDesemprego.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguroDesemprego.Location = new System.Drawing.Point(46, 165);
            this.btnSeguroDesemprego.Name = "btnSeguroDesemprego";
            this.btnSeguroDesemprego.Size = new System.Drawing.Size(99, 27);
            this.btnSeguroDesemprego.TabIndex = 2;
            this.btnSeguroDesemprego.Text = "Calcular";
            this.btnSeguroDesemprego.UseVisualStyleBackColor = true;
            this.btnSeguroDesemprego.Click += new System.EventHandler(this.btnSeguroDesemprego_Click);
            // 
            // panelResulatdoS
            // 
            this.panelResulatdoS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelResulatdoS.Controls.Add(this.lblResultadoS);
            this.panelResulatdoS.Location = new System.Drawing.Point(13, 324);
            this.panelResulatdoS.Name = "panelResulatdoS";
            this.panelResulatdoS.Size = new System.Drawing.Size(775, 114);
            this.panelResulatdoS.TabIndex = 3;
            // 
            // lblResultadoS
            // 
            this.lblResultadoS.AutoSize = true;
            this.lblResultadoS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoS.Location = new System.Drawing.Point(330, 42);
            this.lblResultadoS.Name = "lblResultadoS";
            this.lblResultadoS.Size = new System.Drawing.Size(68, 30);
            this.lblResultadoS.TabIndex = 0;
            this.lblResultadoS.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(236, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 5;
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources._1636547561010_3160919;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelResulatdoS);
            this.Controls.Add(this.btnSeguroDesemprego);
            this.Controls.Add(this.txtSalario1);
            this.Controls.Add(this.lblSalario1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioSeguroDesemprego";
            this.Text = "SEGURO DESEMPREGO";
            this.panelResulatdoS.ResumeLayout(false);
            this.panelResulatdoS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario1;
        private System.Windows.Forms.TextBox txtSalario1;
        private System.Windows.Forms.Button btnSeguroDesemprego;
        private System.Windows.Forms.Panel panelResulatdoS;
        private System.Windows.Forms.Label lblResultadoS;
        private System.Windows.Forms.Label label2;
    }
}