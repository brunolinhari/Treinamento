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
    public partial class FPedido : Form
    {
        public FornecedorRepository fornecedorRepository = new FornecedorRepository();
        public IEnumerable<Fornecedor> Fornecedores { get; set; }

        public ProdutoRepository produtoRepository = new ProdutoRepository();
        public IEnumerable<Produto> Produtos { get; set; }

        public PedidoRepository pedidoRepository = new PedidoRepository();
        public IEnumerable<Pedido> Pedidos { get; set; }

        public EstoqueRepository estoqueRepository = new EstoqueRepository();

        public FPedido()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            //fornecedorRepository = new FornecedorRepository();
            Fornecedores = new List<Fornecedor>();
            Fornecedores = fornecedorRepository.Obter().ToList();
            cbFornecedor.DataSource = null;
            cbFornecedor.DataSource = Fornecedores;
            cbFornecedor.DisplayMember = "Nome";
            cbFornecedor.ValueMember = "Id";
            cbFornecedor.SelectedIndex = -1;

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

        public void AtualizaGrid()
        {
            pedidoRepository = new PedidoRepository();
            Pedidos = new List<Pedido>();
            Pedidos = pedidoRepository.Obter();
            dgPedido.DataSource = null;
            dgPedido.AutoGenerateColumns = false;
            dgPedido.DataSource = Pedidos.ToList();
        }
        private void FPedido_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void cbProduto_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void edVlCompra_Leave(object sender, EventArgs e)
        {
            edVlTotal.Text = Convert.ToString(Convert.ToDecimal(edVlCompra.Text) * edQtdRecebida.Value);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = new Pedido();
                pedido.Numero = Convert.ToInt32(edNumero.Text);
                pedido.FornecedorId = Convert.ToInt32(cbFornecedor.SelectedValue);
                pedido.ProdutoId = Convert.ToInt32(cbProduto.SelectedValue);
                pedido.VlUnitario = Convert.ToDecimal(edVlCompra.Text);
                pedido.QtdRecebida = Convert.ToInt32(edQtdRecebida.Value);
                pedido.VlTotal = Convert.ToDecimal(edVlTotal.Text);
                pedido.DtaRecebimento = edDtaRecebimento.Value;
                pedidoRepository.Inserir(pedido);

                estoqueRepository.AtualizaSaldoEntrada(Convert.ToInt32(cbProduto.SelectedValue),
                                                       Convert.ToInt32(edQtdRecebida.Value));
                MessageBox.Show("Registro incluído com sucesso!");
                ///MessageBox.Show("Estoque atualizado com sucesso!");
                AtualizaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao incluir pedido: {ex.Message}");
            }
        }

        private void cbProduto_DropDownClosed(object sender, EventArgs e)
        {
            if (cbProduto.SelectedIndex >=0)
            {
                Produto produto = produtoRepository.Obter(Convert.ToInt32(cbProduto.SelectedValue));
                edVlCompra.Text = Convert.ToString(produto.VlCompra);
                edVlTotal.Text = Convert.ToString(produto.VlVenda * edQtdRecebida.Value);

            }        
        }

        private void dgPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pedido pedido = (Pedido)(dgPedido.SelectedRows[0].DataBoundItem);
            if (dgPedido.Columns[e.ColumnIndex].Name == "btnEstornar")
            {
                if (dgPedido.SelectedRows.Count > 0)
                {
                    var Resposta = MessageBox.Show("Confirla o estorno do lançamento?", 
                                                 "",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Exclamation);
                    if (Resposta == DialogResult.Yes)
                    {

                        try
                        {
                            pedidoRepository.Apagar(pedido.Id);
                            estoqueRepository.AtualizaSaldoSaida(pedido.ProdutoId, pedido.QtdRecebida);
                            AtualizaGrid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Falha ao estornar lançamento: {ex.Message}");
                        }
                    }                   
                }
            }
        }
    }
}
