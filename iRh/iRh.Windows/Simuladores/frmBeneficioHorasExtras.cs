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
    public partial class frmBeneficioHorasExtras : Form
    {
        public frmBeneficioHorasExtras()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btnCalculo.Text))
            {
                MessageBox.Show("Informe seu salário base por favor!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBase.Focus();
                return;

            }
            try
            {
                var salario = double.Parse(txtSalarioBase.Text);
                var descontoFgts = HoraExtra.calcule(salario);
                lblResultadoH.Text = "R$" + descontoFgts.ToString("F2");
                panelResultadoH.Visible = true;
            }
            catch
            {
                MessageBox.Show("Informe um valor valido por favor!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
