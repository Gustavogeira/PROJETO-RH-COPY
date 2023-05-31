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
    public partial class frmBeneficioFerias : Form
    {
        public frmBeneficioFerias()
        {
            InitializeComponent();
        }

        private void btnFerias_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btnFerias.Text))
            {
                MessageBox.Show("Informe seu salário base por favor!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFerias.Focus();
                return;

            }
            try
            {
                var salario = double.Parse(txtFerias.Text);
                var descontoFgts = Fgts.calcula(salario);
                lblResulatdoF.Text = "R$" + descontoFgts.ToString("F2");
                panelResultadoF.Visible = true;
            }
            catch
            {
                MessageBox.Show("Informe um valor valido por favor!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
