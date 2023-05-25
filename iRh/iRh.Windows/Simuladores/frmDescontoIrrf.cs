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
    public partial class frmDescontoIrrf : Form
    {
        public frmDescontoIrrf()
        {
            InitializeComponent();
        }

        private void btnIrpf_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(btnIrpf.Text))
            {
                MessageBox.Show("Informe seu salário base por favor!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIrpf.Focus();
                return;

            }
            try
            {
                var salario = double.Parse(txtIrpf.Text);
                MessageBox.Show("SUA FAIXA SALARIAL ESTÁ ISENTA O IMPOSTO DE RENDA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var descontoFgts = Fgts.calcula(salario);
                lblResultado.Text = "R$" + descontoFgts.ToString("F2");
               panelResultado.Visible = true;
              
            }
            catch
            {
                MessageBox.Show("Informe um valor valido por favor!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
