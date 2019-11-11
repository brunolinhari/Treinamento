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
    public partial class FFornecedor : Form
    {
        public FornecedorRepository fornecedorRepository { get; set; }
        public IEnumerable<Fornecedor> Fornecedores { get; set; }

        public FFornecedor()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            fornecedorRepository = new FornecedorRepository();
            Fornecedores = new List<Fornecedor>();
            Fornecedores = fornecedorRepository.Obter().ToList();
            cbFornecedor.DataSource = null;
            cbFornecedor.DataSource = Fornecedores;
            cbFornecedor.DisplayMember = "Nome";
            cbFornecedor.ValueMember = "Id";
            cbFornecedor.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FornecedorRepository FornecedorRepository = new FornecedorRepository();
            Fornecedor Fornecedor = new Fornecedor();
            Fornecedor.Nome = cbFornecedor.Text;
            Fornecedor.Ativo = ckAtivo.Checked;
            if (edId.Text == "")
            {
                FornecedorRepository.Inserir(Fornecedor);
                MessageBox.Show("Registro incluído com sucesso");
            }
            else
            {
                Fornecedor.Id = Convert.ToInt32(edId.Text);                
                FornecedorRepository.Editar(Fornecedor);
                MessageBox.Show("Registro alterado com sucesso");
            }
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (edId.Text != "")
            {
                fornecedorRepository.Apagar(Convert.ToInt32(edId.Text));
                MessageBox.Show("Fornecedor excluído com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Informe o fornecedor!");
            }
        }

        private void FFornecedor_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void cbFornecedor_DropDownClosed(object sender, EventArgs e)
        {

            if (cbFornecedor.SelectedIndex >= 0)
            {
                edId.Text = cbFornecedor.SelectedValue.ToString();
                Fornecedor fornecedor = fornecedorRepository.Obter(Convert.ToInt32(edId.Text));
                ckAtivo.Checked = fornecedor.Ativo; 
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
