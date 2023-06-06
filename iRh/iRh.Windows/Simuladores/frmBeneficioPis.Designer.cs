namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioPis));
            this.lblPis = new System.Windows.Forms.Label();
            this.txtPis = new System.Windows.Forms.TextBox();
            this.btnPis = new System.Windows.Forms.Button();
            this.panelResultadoPis = new System.Windows.Forms.Panel();
            this.lblResultadoPis = new System.Windows.Forms.Label();
            this.panelResultadoPis.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPis
            // 
            this.lblPis.AutoSize = true;
            this.lblPis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPis.Location = new System.Drawing.Point(28, 39);
            this.lblPis.Name = "lblPis";
            this.lblPis.Size = new System.Drawing.Size(124, 30);
            this.lblPis.TabIndex = 0;
            this.lblPis.Text = "Salário Base";
            // 
            // txtPis
            // 
            this.txtPis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPis.Location = new System.Drawing.Point(33, 101);
            this.txtPis.Name = "txtPis";
            this.txtPis.Size = new System.Drawing.Size(119, 29);
            this.txtPis.TabIndex = 1;
            // 
            // btnPis
            // 
            this.btnPis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPis.Location = new System.Drawing.Point(33, 166);
            this.btnPis.Name = "btnPis";
            this.btnPis.Size = new System.Drawing.Size(87, 28);
            this.btnPis.TabIndex = 2;
            this.btnPis.Text = "Calcular";
            this.btnPis.UseVisualStyleBackColor = true;
            this.btnPis.Click += new System.EventHandler(this.btnPis_Click);
            // 
            // panelResultadoPis
            // 
            this.panelResultadoPis.BackColor = System.Drawing.Color.SteelBlue;
            this.panelResultadoPis.Controls.Add(this.lblResultadoPis);
            this.panelResultadoPis.Location = new System.Drawing.Point(13, 309);
            this.panelResultadoPis.Name = "panelResultadoPis";
            this.panelResultadoPis.Size = new System.Drawing.Size(775, 129);
            this.panelResultadoPis.TabIndex = 3;
            this.panelResultadoPis.Visible = false;
            // 
            // lblResultadoPis
            // 
            this.lblResultadoPis.AutoSize = true;
            this.lblResultadoPis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPis.Location = new System.Drawing.Point(340, 45);
            this.lblResultadoPis.Name = "lblResultadoPis";
            this.lblResultadoPis.Size = new System.Drawing.Size(68, 30);
            this.lblResultadoPis.TabIndex = 0;
            this.lblResultadoPis.Text = "label1";
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.pis_01_1551276963200_v2_956x506;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultadoPis);
            this.Controls.Add(this.btnPis);
            this.Controls.Add(this.txtPis);
            this.Controls.Add(this.lblPis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioPis";
            this.Text = "PIS";
            this.panelResultadoPis.ResumeLayout(false);
            this.panelResultadoPis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPis;
        private System.Windows.Forms.TextBox txtPis;
        private System.Windows.Forms.Button btnPis;
        private System.Windows.Forms.Panel panelResultadoPis;
        private System.Windows.Forms.Label lblResultadoPis;
    }
}