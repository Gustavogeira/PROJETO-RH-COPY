namespace iRh.Windows.Cadastros
{
    partial class frmFuncionarios
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mtxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.lblDdd = new System.Windows.Forms.Label();
            this.txtDdd = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnCep = new System.Windows.Forms.Button();
            this.btnTelefone = new System.Windows.Forms.Button();
            this.linkLblTelefone = new System.Windows.Forms.LinkLabel();
            this.lblDocumentos = new System.Windows.Forms.Label();
            this.cmbDocumentos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(36, 20);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(103, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "NOME COMPLETO";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(40, 36);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(116, 22);
            this.txtNome.TabIndex = 1;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(202, 20);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 36);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 22);
            this.textBox2.TabIndex = 3;
            // 
            // mtxtDataNascimento
            // 
            this.mtxtDataNascimento.Location = new System.Drawing.Point(374, 36);
            this.mtxtDataNascimento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtxtDataNascimento.Mask = "00/00/0000";
            this.mtxtDataNascimento.Name = "mtxtDataNascimento";
            this.mtxtDataNascimento.Size = new System.Drawing.Size(137, 22);
            this.mtxtDataNascimento.TabIndex = 4;
            this.mtxtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNascimento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(370, 20);
            this.lblDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(128, 13);
            this.lblDataNascimento.TabIndex = 5;
            this.lblDataNascimento.Text = "DATA DE NASCIMENTO";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.Color.Transparent;
            this.lblCep.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(40, 136);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(27, 13);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(43, 152);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(116, 22);
            this.txtCep.TabIndex = 7;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.BackColor = System.Drawing.Color.Transparent;
            this.lblLogradouro.Location = new System.Drawing.Point(40, 177);
            this.lblLogradouro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(83, 13);
            this.lblLogradouro.TabIndex = 8;
            this.lblLogradouro.Text = "LOGRADOURO";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(40, 194);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(154, 22);
            this.txtLogradouro.TabIndex = 9;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Location = new System.Drawing.Point(216, 177);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(56, 13);
            this.lblNumero.TabIndex = 10;
            this.lblNumero.Text = "NÙMERO";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(219, 194);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(60, 22);
            this.txtNumero.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Location = new System.Drawing.Point(321, 177);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(47, 13);
            this.lblBairro.TabIndex = 12;
            this.lblBairro.Text = "BAIRRO";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(324, 193);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(187, 22);
            this.txtBairro.TabIndex = 13;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Location = new System.Drawing.Point(40, 253);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 13);
            this.lblCidade.TabIndex = 14;
            this.lblCidade.Text = "CIDADE";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(39, 268);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(136, 22);
            this.txtCidade.TabIndex = 15;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.BackColor = System.Drawing.Color.Transparent;
            this.lblUf.Location = new System.Drawing.Point(190, 252);
            this.lblUf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(67, 13);
            this.lblUf.TabIndex = 16;
            this.lblUf.Text = "UF/ESTADO";
            // 
            // cmbUf
            // 
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Location = new System.Drawing.Point(194, 268);
            this.cmbUf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(140, 21);
            this.cmbUf.TabIndex = 17;
            // 
            // lblDdd
            // 
            this.lblDdd.AutoSize = true;
            this.lblDdd.BackColor = System.Drawing.Color.Transparent;
            this.lblDdd.Location = new System.Drawing.Point(43, 320);
            this.lblDdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDdd.Name = "lblDdd";
            this.lblDdd.Size = new System.Drawing.Size(31, 13);
            this.lblDdd.TabIndex = 18;
            this.lblDdd.Text = "DDD";
            // 
            // txtDdd
            // 
            this.txtDdd.Location = new System.Drawing.Point(43, 337);
            this.txtDdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(51, 22);
            this.txtDdd.TabIndex = 19;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Location = new System.Drawing.Point(119, 320);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(60, 13);
            this.lblTelefone.TabIndex = 20;
            this.lblTelefone.Text = "TELEFONE";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(122, 336);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(116, 22);
            this.txtTelefone.TabIndex = 21;
            // 
            // btnCep
            // 
            this.btnCep.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCep.Location = new System.Drawing.Point(167, 150);
            this.btnCep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCep.Name = "btnCep";
            this.btnCep.Size = new System.Drawing.Size(88, 23);
            this.btnCep.TabIndex = 23;
            this.btnCep.Text = "Pesquisar";
            this.btnCep.UseVisualStyleBackColor = true;
            this.btnCep.Click += new System.EventHandler(this.btnCep_Click);
            // 
            // btnTelefone
            // 
            this.btnTelefone.BackColor = System.Drawing.Color.Transparent;
            this.btnTelefone.BackgroundImage = global::iRh.Windows.Properties.Resources.images;
            this.btnTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTelefone.Location = new System.Drawing.Point(246, 328);
            this.btnTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTelefone.Name = "btnTelefone";
            this.btnTelefone.Size = new System.Drawing.Size(48, 37);
            this.btnTelefone.TabIndex = 24;
            this.btnTelefone.UseVisualStyleBackColor = false;
            // 
            // linkLblTelefone
            // 
            this.linkLblTelefone.AutoSize = true;
            this.linkLblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.linkLblTelefone.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblTelefone.Location = new System.Drawing.Point(313, 344);
            this.linkLblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLblTelefone.Name = "linkLblTelefone";
            this.linkLblTelefone.Size = new System.Drawing.Size(89, 13);
            this.linkLblTelefone.TabIndex = 25;
            this.linkLblTelefone.TabStop = true;
            this.linkLblTelefone.Text = "Chamar no Zap";
            this.linkLblTelefone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblTelefone_LinkClicked);
            // 
            // lblDocumentos
            // 
            this.lblDocumentos.AutoSize = true;
            this.lblDocumentos.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumentos.Location = new System.Drawing.Point(36, 71);
            this.lblDocumentos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentos.Name = "lblDocumentos";
            this.lblDocumentos.Size = new System.Drawing.Size(186, 13);
            this.lblDocumentos.TabIndex = 26;
            this.lblDocumentos.Text = "DOCUMENTOS DE IDENTIFICAÇÃO";
            // 
            // cmbDocumentos
            // 
            this.cmbDocumentos.FormattingEnabled = true;
            this.cmbDocumentos.Location = new System.Drawing.Point(39, 87);
            this.cmbDocumentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDocumentos.Name = "cmbDocumentos";
            this.cmbDocumentos.Size = new System.Drawing.Size(216, 21);
            this.cmbDocumentos.TabIndex = 27;
            this.cmbDocumentos.SelectedIndexChanged += new System.EventHandler(this.cmbDocumentos_SelectedIndexChanged);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.LGPD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 454);
            this.Controls.Add(this.cmbDocumentos);
            this.Controls.Add(this.lblDocumentos);
            this.Controls.Add(this.linkLblTelefone);
            this.Controls.Add(this.btnTelefone);
            this.Controls.Add(this.btnCep);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtDdd);
            this.Controls.Add(this.lblDdd);
            this.Controls.Add(this.cmbUf);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.mtxtDataNascimento);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmFuncionarios";
            this.Text = "frmFuncionarios";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox mtxtDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.Label lblDdd;
        private System.Windows.Forms.TextBox txtDdd;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnCep;
        private System.Windows.Forms.Button btnTelefone;
        private System.Windows.Forms.LinkLabel linkLblTelefone;
        private System.Windows.Forms.Label lblDocumentos;
        private System.Windows.Forms.ComboBox cmbDocumentos;
    }
}