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
    public partial class frmBeneficioFgts : Form
    {
        public frmBeneficioFgts()
        {
            InitializeComponent();
        }

        private void btnFgts_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(btnFgts.Text))
            {
                MessageBox.Show("Informe seu salário base por favor!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFgts.Focus();
                return;

            }
            try
            {
                var salario = double.Parse(txtFgts.Text);
                var descontoFgts = Fgts.calcula(salario);
                lblResultado.Text = "R$" + descontoFgts.ToString("F2");
                panelResltado.Visible = true;
            }
            catch
            {
                MessageBox.Show("Informe um valor valido por favor!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
