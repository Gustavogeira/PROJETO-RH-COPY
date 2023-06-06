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
    public partial class frmBeneficioPis : Form
    {
        public frmBeneficioPis()
        {
            InitializeComponent();
        }

        private void btnPis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btnPis.Text))
            {
                MessageBox.Show("Informe seu salário base por favor!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPis.Focus();
                return;

            }
            try
            {
                var salario = double.Parse(txtPis.Text);
                var descontoFgts = Fgts.calcula(salario);
                lblResultadoPis.Text = "R$" + descontoFgts.ToString("F2");
                panelResultadoPis.Visible = true;
            }
            catch
            {
                MessageBox.Show("Informe um valor valido por favor!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
