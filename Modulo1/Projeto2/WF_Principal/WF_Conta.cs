using Projeto2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Principal
{
    public partial class WF_Conta : Form
    {
        public ContaRepository contaRepository { get; set; }

        public IEnumerable<Conta> Contas { get; set; }

        public void Initialize()
        {
            contaRepository = new ContaRepository();
            Contas = new List<Conta>();
            dgContas.AutoGenerateColumns = false;
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            Contas = contaRepository.Obter();
            dgContas.DataSource = null;
            dgContas.DataSource = Contas.ToList();
        }

        public WF_Conta()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            WF_Cad_Cliente frmCad_Cliente = new WF_Cad_Cliente();
            frmCad_Cliente.ShowDialog();
            AtualizaGrid();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            WF_Cad_Conta frmCad_Conta = new WF_Cad_Conta();
            frmCad_Conta.ShowDialog();
            AtualizaGrid();
        }

        private void btnBanco_Click(object sender, EventArgs e)
        {
            WF_Cad_Banco frmCad_Banco = new WF_Cad_Banco();
            frmCad_Banco.ShowDialog();
            AtualizaGrid();
        }

        private void btnCxEletronico_Click(object sender, EventArgs e)
        {
            WF_Caixa_Eletronico frmCaixa_Eletronico = new WF_Caixa_Eletronico();
            frmCaixa_Eletronico.ShowDialog();
            AtualizaGrid();
        }

        private void WF_Conta_Load(object sender, EventArgs e)
        {

        }
    }
}
