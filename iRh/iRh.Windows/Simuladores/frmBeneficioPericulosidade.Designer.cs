namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPericulosidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioPericulosidade));
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtPericulosidade = new System.Windows.Forms.TextBox();
            this.btnCalcularP = new System.Windows.Forms.Button();
            this.panelResultadoP = new System.Windows.Forms.Panel();
            this.lblResultadoP = new System.Windows.Forms.Label();
            this.panelResultadoP.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.White;
            this.lblSalario.Location = new System.Drawing.Point(26, 34);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(124, 30);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Salário Base";
            // 
            // txtPericulosidade
            // 
            this.txtPericulosidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPericulosidade.Location = new System.Drawing.Point(31, 81);
            this.txtPericulosidade.Name = "txtPericulosidade";
            this.txtPericulosidade.Size = new System.Drawing.Size(119, 29);
            this.txtPericulosidade.TabIndex = 1;
            // 
            // btnCalcularP
            // 
            this.btnCalcularP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularP.Location = new System.Drawing.Point(31, 147);
            this.btnCalcularP.Name = "btnCalcularP";
            this.btnCalcularP.Size = new System.Drawing.Size(100, 31);
            this.btnCalcularP.TabIndex = 2;
            this.btnCalcularP.Text = "Calcular";
            this.btnCalcularP.UseVisualStyleBackColor = true;
            this.btnCalcularP.Click += new System.EventHandler(this.btnCalcularP_Click);
            // 
            // panelResultadoP
            // 
            this.panelResultadoP.Controls.Add(this.lblResultadoP);
            this.panelResultadoP.Location = new System.Drawing.Point(13, 308);
            this.panelResultadoP.Name = "panelResultadoP";
            this.panelResultadoP.Size = new System.Drawing.Size(775, 133);
            this.panelResultadoP.TabIndex = 3;
            this.panelResultadoP.Visible = false;
            // 
            // lblResultadoP
            // 
            this.lblResultadoP.AutoSize = true;
            this.lblResultadoP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoP.Location = new System.Drawing.Point(329, 52);
            this.lblResultadoP.Name = "lblResultadoP";
            this.lblResultadoP.Size = new System.Drawing.Size(68, 30);
            this.lblResultadoP.TabIndex = 0;
            this.lblResultadoP.Text = "label1";
            // 
            // frmBeneficioPericulosidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.insalubridade_e_periculosidade;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultadoP);
            this.Controls.Add(this.btnCalcularP);
            this.Controls.Add(this.txtPericulosidade);
            this.Controls.Add(this.lblSalario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioPericulosidade";
            this.Text = "PERICULOSIDADE";
            this.panelResultadoP.ResumeLayout(false);
            this.panelResultadoP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtPericulosidade;
        private System.Windows.Forms.Button btnCalcularP;
        private System.Windows.Forms.Panel panelResultadoP;
        private System.Windows.Forms.Label lblResultadoP;
    }
}