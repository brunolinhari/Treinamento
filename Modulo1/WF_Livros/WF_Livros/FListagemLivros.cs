using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Livros
{
    public partial class FListagemLivros : Form
    {
        public List<Livro> Livros { get; set; }

        public FListagemLivros()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize() 
        {
            Livros = new List<Livro>();

            dgListagemLivros.AutoGenerateColumns = false;
            dgListagemLivros.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgListagemLivros.Columns["NrPaginas"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            /*Livros.Add(new Livro()
            {
                Autor = "Autor 2",
                DataLancamento = DateTime.Now.AddMonths(-15),
                id = 1,
                NumeroPaginas = 20,
                Titulo = "Titulo 2"
            });

            Livros.Add(new Livro()
            {
                Autor = "Autor 3",
                DataLancamento = DateTime.Now.AddMonths(-25),
                id = 2,
                NumeroPaginas = 20,
                Titulo = "Titulo 3"
            });
            Livros.Add(new Livro()
            {
                Autor = "Autor 4",
                DataLancamento = DateTime.Now.AddMonths(-35),
                id = 3,
                NumeroPaginas = 20,
                Titulo = "Titulo 4"
            });*/

            dgListagemLivros.DataSource = Livros;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();

            Livros.Add(frm.LivroManutencao);
            AtualizarGrid();
        }

        private void dgListagemLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgListagemLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Livro ItemSelecionado = (Livro)dgListagemLivros.Rows[e.RowIndex].DataBoundItem;
            //MessageBox.Show(dgListagemLivros.Columns[e.ColumnIndex].Name);
            if (dgListagemLivros.Columns[e.ColumnIndex].Name != "btnApagar") {
                Form1 frm = new Form1();
                frm.PreencherLivro(ItemSelecionado);
                frm.ShowDialog();

                Livros.Add(frm.LivroManutencao);
                Livros.Remove(ItemSelecionado);
                AtualizarGrid();
            }

            if (dgListagemLivros.Columns[e.ColumnIndex].Name == "btnApagar")
            {
                DialogResult result = MessageBox.Show("Deseja apagar o item?", 
                                                      "Remover", 
                                                      MessageBoxButtons.YesNo, 
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Livros.Remove(ItemSelecionado);
                    AtualizarGrid();
                }
            }
        }

        private void AtualizarGrid()
        {
            dgListagemLivros.DataSource = null;
            dgListagemLivros.DataSource = Livros.OrderBy(campo => campo.Autor).ToList();
        }
    }
}
