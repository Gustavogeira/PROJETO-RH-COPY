﻿using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmDescontoInss : Form
    {
        public frmDescontoInss()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("informe seu salário base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }


            try
            {
                var salario = double.Parse(txtSalario.Text);
                var descontoInss = Inss.Calcula(salario);

                lblResulatdo.Text = descontoInss.ToString("c");
                panelResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("informe um salário válido, ex. 3500", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }
    }
}
