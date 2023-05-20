namespace iRh.Windows
{
    partial class PrincipalMdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMdi));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menudescontoInss = new System.Windows.Forms.ToolStripMenuItem();
            this.menudescontoIrrf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBeneficioAdicionalNortuno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficiofgts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioFerias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioHorasExtras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioPericulosidade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioPis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioseguroDesemprego = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioValetransporte = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem,
            this.simuladoresToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "menuStrip2";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFuncionario});
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.funcionariosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuFuncionario
            // 
            this.menuFuncionario.Name = "menuFuncionario";
            this.menuFuncionario.Size = new System.Drawing.Size(142, 22);
            this.menuFuncionario.Text = "Funcionarios";
            this.menuFuncionario.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // simuladoresToolStripMenuItem
            // 
            this.simuladoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menudescontoInss,
            this.menudescontoIrrf,
            this.toolStripSeparator1,
            this.menuBeneficioAdicionalNortuno,
            this.menuBeneficiofgts,
            this.menuBeneficioFerias,
            this.menuBeneficioHorasExtras,
            this.menuBeneficioPericulosidade,
            this.menuBeneficioPis,
            this.menuBeneficioseguroDesemprego,
            this.menuBeneficioValetransporte});
            this.simuladoresToolStripMenuItem.Name = "simuladoresToolStripMenuItem";
            this.simuladoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.simuladoresToolStripMenuItem.Text = "Simuladores";
            // 
            // menudescontoInss
            // 
            this.menudescontoInss.Name = "menudescontoInss";
            this.menudescontoInss.Size = new System.Drawing.Size(249, 22);
            this.menudescontoInss.Text = "Desconto de INSS";
            this.menudescontoInss.Click += new System.EventHandler(this.menudescontoInss_Click);
            // 
            // menudescontoIrrf
            // 
            this.menudescontoIrrf.Name = "menudescontoIrrf";
            this.menudescontoIrrf.Size = new System.Drawing.Size(249, 22);
            this.menudescontoIrrf.Text = "Desconto de IRPF";
            this.menudescontoIrrf.Click += new System.EventHandler(this.menudescontoIrrf_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // menuBeneficioAdicionalNortuno
            // 
            this.menuBeneficioAdicionalNortuno.Name = "menuBeneficioAdicionalNortuno";
            this.menuBeneficioAdicionalNortuno.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioAdicionalNortuno.Text = "Beneficio de Adicional Noturno";
            this.menuBeneficioAdicionalNortuno.Click += new System.EventHandler(this.menuBeneficioAdicionalNortuno_Click);
            // 
            // menuBeneficiofgts
            // 
            this.menuBeneficiofgts.Name = "menuBeneficiofgts";
            this.menuBeneficiofgts.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficiofgts.Text = "Beneficio de Deposito FGTS";
            this.menuBeneficiofgts.Click += new System.EventHandler(this.menuBeneficiofgts_Click);
            // 
            // menuBeneficioFerias
            // 
            this.menuBeneficioFerias.Name = "menuBeneficioFerias";
            this.menuBeneficioFerias.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioFerias.Text = "Beneficio de Férias";
            this.menuBeneficioFerias.Click += new System.EventHandler(this.beneficioDeFériasToolStripMenuItem_Click);
            // 
            // menuBeneficioHorasExtras
            // 
            this.menuBeneficioHorasExtras.Name = "menuBeneficioHorasExtras";
            this.menuBeneficioHorasExtras.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioHorasExtras.Text = "Beneficio Horas Extras";
            this.menuBeneficioHorasExtras.Click += new System.EventHandler(this.menuBeneficioHorasExtras_Click);
            // 
            // menuBeneficioPericulosidade
            // 
            this.menuBeneficioPericulosidade.Name = "menuBeneficioPericulosidade";
            this.menuBeneficioPericulosidade.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioPericulosidade.Text = "Beneficio de Periculosidade";
            this.menuBeneficioPericulosidade.Click += new System.EventHandler(this.menuBeneficioPericulosidade_Click);
            // 
            // menuBeneficioPis
            // 
            this.menuBeneficioPis.Name = "menuBeneficioPis";
            this.menuBeneficioPis.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioPis.Text = "Beneficio de PIS";
            this.menuBeneficioPis.Click += new System.EventHandler(this.menuBeneficioPis_Click);
            // 
            // menuBeneficioseguroDesemprego
            // 
            this.menuBeneficioseguroDesemprego.Name = "menuBeneficioseguroDesemprego";
            this.menuBeneficioseguroDesemprego.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioseguroDesemprego.Text = "Beneficio de Seguro Desemprego";
            this.menuBeneficioseguroDesemprego.Click += new System.EventHandler(this.menuBeneficioseguroDesemprego_Click);
            // 
            // menuBeneficioValetransporte
            // 
            this.menuBeneficioValetransporte.Name = "menuBeneficioValetransporte";
            this.menuBeneficioValetransporte.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioValetransporte.Text = "Beneficio de Vale transporte";
            this.menuBeneficioValetransporte.Click += new System.EventHandler(this.menuBeneficioValetransporte_Click);
            // 
            // PrincipalMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "PrincipalMdi";
            this.Text = "PrincipalMdi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrincipalMdi_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simuladoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menudescontoInss;
        private System.Windows.Forms.ToolStripMenuItem menudescontoIrrf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioAdicionalNortuno;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficiofgts;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioFerias;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioPis;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioseguroDesemprego;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioHorasExtras;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioPericulosidade;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioValetransporte;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionario;
    }
}