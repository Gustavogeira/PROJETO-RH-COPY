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
            CarregarDocumentos();
        }

        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();
            var estadoAz = listaEstados.OrderBy(x => x.Sigla).ToList();
            cmbUf.Items.Clear();
            cmbUf.DataSource = estadoAz;
            cmbUf.DisplayMember = "Nome";
            cmbUf.ValueMember = "Sigla";  
            

        }
        private void CarregarDocumentos()
        {
            var estado = new Documentos();
            var listadeDocumentos = estado.ObterTodosDocumentos();
            var documentosAz = listadeDocumentos.OrderBy(x => x.Descrição).ToList();
            cmbDocumentos.Items.Clear();
            cmbDocumentos.DataSource = documentosAz;
            cmbDocumentos.DisplayMember = "Descrição";
            cmbDocumentos.ValueMember = "Id";
        }
        


        private void linkLblTelefone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void cmbDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCep_Click(object sender, EventArgs e)
        {
            var cepDigitado = txtCep.Text;

            var endereco = new Endereco();
            var  enderecoCompleto = endereco.ObterPorCep(cepDigitado);
            if(enderecoCompleto == null)
            {
            MessageBox.Show("Coloque um CEP válido!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            txtCep.Focus();
            return;
            }

            txtLogradouro.Text = enderecoCompleto.Logradouro;
            txtBairro.Text = enderecoCompleto.Bairro;
            txtCidade.Text = enderecoCompleto.Localidade;
            txtDdd.Text = enderecoCompleto.Ddd;
            cmbUf.SelectedValue = enderecoCompleto.Uf;

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            txtCidade.Enabled = false;
        }

        private void txtDdd_TextChanged(object sender, EventArgs e)
        {
            txtDdd.Enabled = false;
        }

        private void cmbUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUf.Enabled = false;
        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {
            txtLogradouro.Enabled = false;
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            txtBairro.Enabled = false;
        }
    }
}
