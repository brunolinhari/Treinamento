using Projeto3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Mercado
{
    public partial class FProduto : Form
    {
        public ProdutoRepository produtoRepository { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }

        public FProduto()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            produtoRepository = new ProdutoRepository();
            Produtos = new List<Produto>();
            Produtos = produtoRepository.Obter().ToList();
            cbProduto.DataSource = null;
            cbProduto.DataSource = Produtos;
            cbProduto.DisplayMember = "Descricao";
            cbProduto.ValueMember = "Id";
            cbProduto.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoRepository produtoRepository = new ProdutoRepository();
            Produto produto = new Produto();
            produto.Descricao = cbProduto.Text;
            produto.VlCompra = Convert.ToDecimal(edVlCompra.Text);
            produto.Lucro = Convert.ToDecimal(edLucro.Text);
            produto.VlVenda = Convert.ToDecimal(edVlVenda.Text);
            produto.Ativo = ckAtivo.Checked;
            if (edId.Text == "")
            {
                produtoRepository.Inserir(produto);
                MessageBox.Show("Registro incluído com sucesso");
            }
            else
            {
                produto.Id = Convert.ToInt32(edId.Text);
                produtoRepository.Editar(produto);
                MessageBox.Show("Registro alterado com sucesso");
            }
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FProduto_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (edId.Text != "")
            {
                produtoRepository.Apagar(Convert.ToInt32(edId.Text));
                MessageBox.Show("Registro excluído com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Informe o Produto");
            }
        }

        private void cbProduto_DropDownClosed(object sender, EventArgs e)
        {
            if (cbProduto.SelectedIndex >= 0)
            {
                //edId.Text = cbCliente.SelectedValue.ToString();
                //Cliente cliente = clienteRepository.Obter(Convert.ToInt32(edId.Text));
                //edDtaNascimento.Value = cliente.DataNascimento;

                edId.Text = cbProduto.SelectedValue.ToString();
                Produto produto = produtoRepository.Obter(Convert.ToInt32(edId.Text));
                edVlCompra.Text = Convert.ToString(produto.VlCompra);
                edLucro.Text = Convert.ToString(produto.Lucro);
                edVlVenda.Text = Convert.ToString(produto.VlVenda);
                ckAtivo.Checked = produto.Ativo;
            }        
        }

        private void edVlCompra_Leave(object sender, EventArgs e)
        {
            if (edVlCompra.Text != "" && edLucro.Text != "")
            {
                edVlVenda.Text = Convert.ToString(Convert.ToDecimal(edVlCompra.Text) * Convert.ToDecimal(edLucro.Text));
            }        
        }

        private void edVlVenda_Leave(object sender, EventArgs e)
        {
            if (edVlVenda.Text != "" && edVlCompra.Text != "")
            {
                edLucro.Text = Convert.ToString(Convert.ToDecimal(edVlVenda.Text) / Convert.ToDecimal(edVlCompra.Text));
            }
        }
    }
}
