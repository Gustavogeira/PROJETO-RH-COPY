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

namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }
        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            CarregarEstados();
        }

        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();

            cmbUf.Items.Clear();
            cmbUf.DataSource = listaEstados.OrderBy(x => x.Sigla);
            cmbUf.DisplayMember = "Sigla";
            cmbUf.ValueMember = "id";  
            

        }

        private void linkLblTelefone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
