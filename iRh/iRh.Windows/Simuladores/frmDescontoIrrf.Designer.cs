namespace iRh.Windows.Simuladores
{
    partial class frmDescontoIrrf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescontoIrrf));
            this.lblIrpf = new System.Windows.Forms.Label();
            this.txtIrpf = new System.Windows.Forms.TextBox();
            this.btnIrpf = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIrpf
            // 
            this.lblIrpf.AutoSize = true;
            this.lblIrpf.BackColor = System.Drawing.Color.Transparent;
            this.lblIrpf.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIrpf.ForeColor = System.Drawing.Color.White;
            this.lblIrpf.Location = new System.Drawing.Point(13, 44);
            this.lblIrpf.Name = "lblIrpf";
            this.lblIrpf.Size = new System.Drawing.Size(75, 30);
            this.lblIrpf.TabIndex = 0;
            this.lblIrpf.Text = "Salário";
            // 
            // txtIrpf
            // 
            this.txtIrpf.Location = new System.Drawing.Point(13, 92);
            this.txtIrpf.Name = "txtIrpf";
            this.txtIrpf.Size = new System.Drawing.Size(100, 20);
            this.txtIrpf.TabIndex = 1;
            // 
            // btnIrpf
            // 
            this.btnIrpf.BackColor = System.Drawing.Color.Transparent;
            this.btnIrpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrpf.ForeColor = System.Drawing.Color.Black;
            this.btnIrpf.Location = new System.Drawing.Point(18, 149);
            this.btnIrpf.Name = "btnIrpf";
            this.btnIrpf.Size = new System.Drawing.Size(75, 28);
            this.btnIrpf.TabIndex = 2;
            this.btnIrpf.Text = "Calcular";
            this.btnIrpf.UseVisualStyleBackColor = false;
            this.btnIrpf.Click += new System.EventHandler(this.btnIrpf_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.ForeColor = System.Drawing.Color.Transparent;
            this.panelResultado.Location = new System.Drawing.Point(13, 218);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(520, 110);
            this.panelResultado.TabIndex = 3;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(209, 42);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 30);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label1";
            // 
            // frmDescontoIrrf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.imposto_de_renda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 335);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnIrpf);
            this.Controls.Add(this.txtIrpf);
            this.Controls.Add(this.lblIrpf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDescontoIrrf";
            this.Text = "Imposto De Renda ";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIrpf;
        private System.Windows.Forms.TextBox txtIrpf;
        private System.Windows.Forms.Button btnIrpf;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}