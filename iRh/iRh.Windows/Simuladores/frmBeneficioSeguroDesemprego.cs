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
    public partial class frmBeneficioSeguroDesemprego : Form
    {
        public frmBeneficioSeguroDesemprego()
        {
            InitializeComponent();
        }

        private void btnSeguroDesemprego_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btnSeguroDesemprego.Text))
            {
                MessageBox.Show("Informe seu salário base por favor!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario1.Focus();
                return;

            }
            try
            {
                var salario = double.Parse(txtSalario1.Text);
                var descontoFgts = HoraExtra.calcule(salario);
                lblResultadoS.Text = "R$" + descontoFgts.ToString("F2");
                panelResulatdoS.Visible = true;
            }
            catch
            {
                MessageBox.Show("Informe um valor valido por favor!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
