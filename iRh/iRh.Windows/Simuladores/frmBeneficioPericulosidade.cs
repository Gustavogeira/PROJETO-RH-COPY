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
    public partial class frmBeneficioPericulosidade : Form
    {
        public frmBeneficioPericulosidade()
        {
            InitializeComponent();
        }

        private void btnCalcularP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btnCalcularP.Text))
            {
                MessageBox.Show("Informe seu salário base por favor!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPericulosidade.Focus();
                return;

            }
            try
            {
                var salario = double.Parse(txtPericulosidade.Text);
                var descontoFgts = Fgts.calcula(salario);
                lblResultadoP.Text = "R$" + descontoFgts.ToString("F2");
                panelResultadoP.Visible = true;
            }
            catch
            {
                MessageBox.Show("Informe um valor valido por favor!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
