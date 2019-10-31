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

namespace WF_MeuProjeto
{
    public partial class Form1 : Form
    {
        public ContaRepository contaRepository { get; set; }

        public IEnumerable<Conta> Contas { get; set; }

        public void Initialize()
        {
            contaRepository = new ContaRepository();
            Contas = new List<Conta>();
            //dgContas.AutoGenerateColumns = false;
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            Contas = contaRepository.Obter();
            //dgContas.DataSource = null;
            //dgContas.DataSource = Contas;
        }
        public Form1()
        {
            InitializeComponent();
        }

    }
}
