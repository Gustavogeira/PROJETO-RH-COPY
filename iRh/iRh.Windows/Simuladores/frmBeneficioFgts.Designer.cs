namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioFgts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioFgts));
            this.lblFgts = new System.Windows.Forms.Label();
            this.txtFgts = new System.Windows.Forms.TextBox();
            this.btnFgts = new System.Windows.Forms.Button();
            this.panelResltado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResltado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFgts
            // 
            this.lblFgts.AutoSize = true;
            this.lblFgts.BackColor = System.Drawing.Color.Transparent;
            this.lblFgts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFgts.Location = new System.Drawing.Point(13, 37);
            this.lblFgts.Name = "lblFgts";
            this.lblFgts.Size = new System.Drawing.Size(75, 30);
            this.lblFgts.TabIndex = 0;
            this.lblFgts.Text = "Salário";
            // 
            // txtFgts
            // 
            this.txtFgts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFgts.Location = new System.Drawing.Point(12, 81);
            this.txtFgts.Name = "txtFgts";
            this.txtFgts.Size = new System.Drawing.Size(100, 29);
            this.txtFgts.TabIndex = 1;
            // 
            // btnFgts
            // 
            this.btnFgts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFgts.Location = new System.Drawing.Point(12, 140);
            this.btnFgts.Name = "btnFgts";
            this.btnFgts.Size = new System.Drawing.Size(83, 27);
            this.btnFgts.TabIndex = 2;
            this.btnFgts.Text = "Calcular";
            this.btnFgts.UseVisualStyleBackColor = true;
            this.btnFgts.Click += new System.EventHandler(this.btnFgts_Click);
            // 
            // panelResltado
            // 
            this.panelResltado.BackColor = System.Drawing.Color.White;
            this.panelResltado.Controls.Add(this.lblResultado);
            this.panelResltado.Location = new System.Drawing.Point(18, 201);
            this.panelResltado.Name = "panelResltado";
            this.panelResltado.Size = new System.Drawing.Size(496, 105);
            this.panelResltado.TabIndex = 3;
            this.panelResltado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(202, 39);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(68, 30);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label1";
            // 
            // frmBeneficioFgts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(526, 309);
            this.Controls.Add(this.panelResltado);
            this.Controls.Add(this.btnFgts);
            this.Controls.Add(this.txtFgts);
            this.Controls.Add(this.lblFgts);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioFgts";
            this.Text = "frmBeneficioFgts";
            this.panelResltado.ResumeLayout(false);
            this.panelResltado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFgts;
        private System.Windows.Forms.TextBox txtFgts;
        private System.Windows.Forms.Button btnFgts;
        private System.Windows.Forms.Panel panelResltado;
        private System.Windows.Forms.Label lblResultado;
    }
}