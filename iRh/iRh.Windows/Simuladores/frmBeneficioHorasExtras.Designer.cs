namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioHorasExtras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioHorasExtras));
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.panelResultadoH = new System.Windows.Forms.Panel();
            this.lblResultadoH = new System.Windows.Forms.Label();
            this.panelResultadoH.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.BackColor = System.Drawing.Color.Transparent;
            this.lblSalarioBase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(29, 37);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(124, 30);
            this.lblSalarioBase.TabIndex = 0;
            this.lblSalarioBase.Text = "Salário Base";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBase.Location = new System.Drawing.Point(34, 82);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(141, 29);
            this.txtSalarioBase.TabIndex = 1;
            // 
            // btnCalculo
            // 
            this.btnCalculo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculo.Location = new System.Drawing.Point(34, 149);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(101, 33);
            this.btnCalculo.TabIndex = 2;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // panelResultadoH
            // 
            this.panelResultadoH.Controls.Add(this.lblResultadoH);
            this.panelResultadoH.Location = new System.Drawing.Point(13, 282);
            this.panelResultadoH.Name = "panelResultadoH";
            this.panelResultadoH.Size = new System.Drawing.Size(775, 156);
            this.panelResultadoH.TabIndex = 3;
            this.panelResultadoH.Visible = false;
            // 
            // lblResultadoH
            // 
            this.lblResultadoH.AutoSize = true;
            this.lblResultadoH.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoH.Location = new System.Drawing.Point(324, 61);
            this.lblResultadoH.Name = "lblResultadoH";
            this.lblResultadoH.Size = new System.Drawing.Size(68, 30);
            this.lblResultadoH.TabIndex = 0;
            this.lblResultadoH.Text = "label1";
            // 
            // frmBeneficioHorasExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources._2cda33914f64b54d168fb4fb6c629dc5__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultadoH);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.lblSalarioBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioHorasExtras";
            this.Text = "HORAS EXTRAS";
            this.panelResultadoH.ResumeLayout(false);
            this.panelResultadoH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Panel panelResultadoH;
        private System.Windows.Forms.Label lblResultadoH;
    }
}