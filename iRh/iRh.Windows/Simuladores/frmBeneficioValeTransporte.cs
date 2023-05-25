using iRh.Windows.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioValeTransporte : Form
    {
        public frmBeneficioValeTransporte()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtValeTransporte.Text))
            {
                MessageBox.Show("Informe o seu salário base por favor!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValeTransporte.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtValeTransporte.Text);
                var descontoValeTransporte = ValeTransporte.Calcula(salario);
                var gastoComPassagem = 336.00;

                if(gastoComPassagem < descontoValeTransporte)
                {
                    panelResultado.Visible = true;
                    lblResultado.Text = "R$" + descontoValeTransporte.ToString("F2");
                    MessageBox.Show("Não vale a pena usar o vale","atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValeTransporte.Focus();
                    return;
                }
                else
                {
                    panelResultado.Visible = true;
                    lblResultado.Text = "R$" + descontoValeTransporte.ToString("F2");
                    MessageBox.Show("vale a pena ultilizar o benefício", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValeTransporte.Focus();
                    return;

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!! ex: 3500", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
