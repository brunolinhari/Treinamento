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
    public partial class FEstoque : Form
    {
        public ProdutoRepository produtoRepository { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }

        public EstoqueRepository estoqueRepository = new EstoqueRepository();
        public IEnumerable<Estoque> Estoques { get; set; }

        public FEstoque()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            estoqueRepository = new EstoqueRepository();
            Estoques = new List<Estoque>();
            dgEstoque.AutoGenerateColumns = false;
            AtualizaGrid();
        }
        public void AtualizaGrid()
        {
            Estoques = estoqueRepository.Obter();
            dgEstoque.DataSource = null;
            dgEstoque.DataSource = Estoques.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FEstoque_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void dgEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Estoque estoque = (Estoque)(dgEstoque.SelectedRows[0].DataBoundItem);
            if (dgEstoque.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (dgEstoque.SelectedRows.Count > 0)
                {
                    edAtualizaSaldo.Visible = true;
                    btnAtualizaSoldo.Visible = true;
                    lblNovoSaldo.Visible = true;
                    edAtualizaSaldo.Text = Convert.ToString(estoque.Saldo);
                    edProdutoId.Text = Convert.ToString(estoque.Id);
                    edSaldoAtual.Text = Convert.ToString(estoque.Saldo);
                }
            }
        }

        private void btnAtualizaSoldo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(edAtualizaSaldo.Text) >= Convert.ToInt32(edSaldoAtual.Text))
                {
                    int iQtdAjuste = Convert.ToInt32(edAtualizaSaldo.Text) - Convert.ToInt32(edSaldoAtual.Text);
                    estoqueRepository.AtualizaSaldoEntrada(Convert.ToInt32(edProdutoId.Text), iQtdAjuste);
                }
                else
                {
                    int iQtdAjuste = Convert.ToInt32(edSaldoAtual.Text) - Convert.ToInt32(edAtualizaSaldo.Text);
                    estoqueRepository.AtualizaSaldoSaida(Convert.ToInt32(edProdutoId.Text), iQtdAjuste);
                }
                lblNovoSaldo.Visible = false;
                edAtualizaSaldo.Visible = false;
                btnAtualizaSoldo.Visible = false;
                Initialize();
                MessageBox.Show("Saldo de estoque atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao atualizar o saldo informado: {ex.Message}");
            }
        }
    }
}
