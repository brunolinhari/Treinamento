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
    public partial class FVenda : Form
    {
        public ClienteRepository clienteRepository = new ClienteRepository();
        public IEnumerable<Cliente> Clientes { get; set; }

        public ProdutoRepository produtoRepository = new ProdutoRepository();
        public IEnumerable<Produto> Produtos { get; set; }

        public VendaRepository vendaRepository = new VendaRepository();

        public IEnumerable<Venda> Vendas { get; set; }

        public EstoqueRepository estoqueRepository = new EstoqueRepository();

        public FVenda()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        {
            Vendas = new List<Venda>();
            Vendas = vendaRepository.Obter();
            dgVenda.DataSource = null;
            //dgVenda.AutoGenerateColumns = false;
            dgVenda.DataSource = Vendas.ToList();
        }

        public void Initialize()
        {
            //clienteRepository = new ClienteRepository();
            Clientes = new List<Cliente>();
            Clientes = clienteRepository.Obter().ToList();
            cbCliente.DataSource = null;
            cbCliente.DataSource = Clientes;
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "Id";
            cbCliente.SelectedIndex = -1;

            //produtoRepository = new ProdutoRepository();
            Produtos = new List<Produto>();
            Produtos = produtoRepository.Obter().ToList();
            cbProduto.DataSource = null;
            cbProduto.DataSource = Produtos;
            cbProduto.DisplayMember = "Descricao";
            cbProduto.ValueMember = "Id";
            cbProduto.SelectedIndex = -1;

            AtualizaGrid();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //VendaRepository vendaRepository = new VendaRepository();
            Venda venda = new Venda();
            venda.ClienteId = Convert.ToInt32(cbCliente.SelectedValue);
            venda.ProdutoId = Convert.ToInt32(cbProduto.SelectedValue);
            venda.VlUnitario = Convert.ToDecimal(edVlVenda.Text);
            venda.Qtde = Convert.ToInt32(edQtde.Value);
            venda.VlTotal = Convert.ToDecimal(edVlTotal.Text);
            vendaRepository.Inserir(venda);
            MessageBox.Show("Registro incluído com sucesso!");
        }

        private void FVenda_Load(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}
