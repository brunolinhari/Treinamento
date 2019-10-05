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
    public partial class Form1 : Form
    {
        //public List<Livro> Livros { get; set; }
        //public Livro Livro = new Livro();

        public Livro LivroManutencao { get; set; }

        public Form1()
        {
            InitializeComponent();

            //Livros = new List<Livro>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            LivroManutencao = new Livro(edTitulo.Text,
                                        edAutor.Text,
                                        edDtaLancamento.Value,
                                        Convert.ToInt32(edNrPaginas.Value));

            //Livros.Add(livro);
            Close();
        }

        public void PreencherLivro(Livro livro) 
        {
            edId.Text = livro.id.ToString();
            edTitulo.Text = livro.Titulo;
            edAutor.Text  = livro.Autor;
            edDtaLancamento.Value = livro.DataLancamento;
            edNrPaginas.Value = livro.NumeroPaginas;
        }
    }
}
