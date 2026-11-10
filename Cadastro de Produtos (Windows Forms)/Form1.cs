using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Produtos__Windows_Forms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            nudPrecoCustoCampo.ValueChanged += nudPrecoCustoCampo_ValueChanged;
            nudPrecoVendaCampo.ValueChanged += nudPrecoVendaCampo_ValueChanged;

            cmbCategoriaCampo.Items.Add("Roupas");
            cmbCategoriaCampo.Items.Add("Calçados");
            cmbCategoriaCampo.Items.Add("Acessórios");
            cmbCategoriaCampo.Items.Add("Outros");

            cmbCategoriaCampo.SelectedIndex = 0;

            btnSalvar.Click += btnSalvar_Click;

            cmbFornecedorCampo.Items.Add("Fornecedor 1");
            cmbFornecedorCampo.Items.Add("Fornecedor 2");
            cmbFornecedorCampo.Items.Add("Fornecedor 3");

            cmbFornecedorCampo.SelectedIndex = 0;

            txtDescricaoCampo.Multiline = true;
            txtDescricaoCampo.ScrollBars = ScrollBars.Vertical;
            txtDescricaoCampo.MaxLength = 500;

            nudStockInicialCampo.Minimum = 0;
            nudStockInicialCampo.Maximum = 100000;
            nudStockInicialCampo.DecimalPlaces = 0;
            nudStockInicialCampo.Increment = 1;
            nudStockInicialCampo.Value = 0;

            nudStockMinimoCampo.Minimum = 0;
            nudStockMinimoCampo.Maximum = 100000;
            nudStockMinimoCampo.DecimalPlaces = 0;
            nudStockMinimoCampo.Increment = 1;
            nudStockMinimoCampo.Value = 0;

            nudPrecoCustoCampo.Minimum = 0;
            nudPrecoCustoCampo.DecimalPlaces = 2;
            nudPrecoCustoCampo.Increment = 0.50m;

            nudPrecoVendaCampo.Minimum = 0;
            nudPrecoVendaCampo.DecimalPlaces = 2;
            nudPrecoVendaCampo.Increment = 0.50m;

            chkProdutoAtivo.Checked = true;
            dtpDataCadastroCampo.Value = DateTime.Today;
            dtpDataCadastroCampo.MaxDate = DateTime.Today;

            btnLimpar.Click += btnLimpar_Click;
            btnExcluir.Click += btnExcluir_Click;
            btnNovo.Click += btnNovo_Click;

            GerarCodigo();

        }
        private void CalcularMargem()
        {
            decimal custo = nudPrecoCustoCampo.Value;
            decimal venda = nudPrecoVendaCampo.Value;

            if (custo > 0)
            {
                decimal margem = ((venda - custo) / custo) * 100;

                txtMargemValor.Text = margem.ToString("N2") + "%";
            }
            else
            {
                txtMargemValor.Text = "0,00%";
            }

        }
        private bool ValidarDadosPrincipais()
        {
            if (string.IsNullOrWhiteSpace(txtNomeCampo.Text))
            {
                MessageBox.Show("Digite o nome do produto");
                txtNomeCampo.Focus();
                return false;
            }

            if (cmbCategoriaCampo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria");
                cmbCategoriaCampo.Focus();
                return false;
            }

            if (cmbFornecedorCampo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um fornecedor");
                cmbFornecedorCampo.Focus();
                return false;
            }

            if (nudStockMinimoCampo.Value > nudStockInicialCampo.Value)
            {
                MessageBox.Show("O estoque mínimo não pode ser maior que o estoque inicial");
                nudStockMinimoCampo.Focus();
                return false;
            }
            if (nudPrecoVendaCampo.Value <= 0)
            {
                MessageBox.Show("O preço de venda deve ser maior que zero");
                nudPrecoVendaCampo.Focus();
                return false;
            }

            if (nudPrecoVendaCampo.Value <= nudPrecoCustoCampo.Value)
            {
                MessageBox.Show("O preço de venda deve ser maior que o preço de custo");
                nudPrecoVendaCampo.Focus();
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarDadosPrincipais())
            {
                return;
            }

            MessageBox.Show("Produto cadastrado com sucesso!!! Código: " + txtCodigoValor.Text);

            proximoCodigo++;

            GerarCodigo();
        }
        private void nudPrecoCustoCampo_ValueChanged(object sender, EventArgs e)
        {
            CalcularMargem();
        }

        private void nudPrecoVendaCampo_ValueChanged(object sender, EventArgs e)
        {
            CalcularMargem();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigoValor.Clear();
            txtNomeCampo.Clear();
            txtDescricaoCampo.Clear();

            cmbCategoriaCampo.SelectedIndex = 0;
            cmbFornecedorCampo.SelectedIndex = 0;

            nudPrecoCustoCampo.Value = 0;
            nudPrecoVendaCampo.Value = 0;

            nudStockInicialCampo.Value = 0;
            nudStockMinimoCampo.Value = 0;

            txtMargemValor.Text = "0,00%";

            chkProdutoAtivo.Checked = true;
            dtpDataCadastroCampo.Value = DateTime.Today;

            txtNomeCampo.Focus();
        }
        private int proximoCodigo = 1;
        private void GerarCodigo()
        {
            txtCodigoValor.Text = "PROD-" + proximoCodigo.ToString("D3");
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Deseja excluir este produto?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                btnLimpar_Click(sender, e);

                MessageBox.Show("Produto excluído com sucesso");
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnLimpar_Click(sender, e);

            GerarCodigo();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
