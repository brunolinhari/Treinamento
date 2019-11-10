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
    public partial class WF_Cad_Conta : Form
    {
        public ClienteRepository clienteRepository { get; set; }
        
        public BancoRepository bancoRepository { get; set; }

        public IEnumerable<Cliente> Clientes { get; set; }

        public IEnumerable<Banco> Bancos { get; set; }

         public void Initialize()
        {
            cbCliente.Items.Clear();
            cbBanco.Items.Clear();

            clienteRepository = new ClienteRepository();
            Clientes = new List<Cliente>();
            Clientes = clienteRepository.Obter();
            for (int i = 0; i < Clientes.Count(); i++)
            {
                cbCliente.Items.Add(Clientes.ElementAt(i).Id + "-" + Clientes.ElementAt(i).Nome);
            }

            bancoRepository = new BancoRepository();
            Bancos = new List<Banco>();
            Bancos = bancoRepository.Obter();
            for (int i = 0; i < Bancos.Count(); i++)
            {
                cbBanco.Items.Add(Bancos.ElementAt(i).Id + "-" + Bancos.ElementAt(i).Nome);
            }

        }
        public WF_Cad_Conta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WF_Cad_Conta_Load(object sender, EventArgs e)
        {
            //cbCliente.Items.Add("Bruno Linhari");
            Initialize();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ContaRepository contaRepository = new ContaRepository();
            Conta conta = new Conta();
            conta.Limite = Convert.ToDecimal(edLimite.Text);
            conta.Saldo = Convert.ToDecimal(edSaldo.Text);
            conta.ContaCorrente = edNrConta.Text;
            conta.Agencia = edAgencia.Text;
            conta.BancoId = Convert.ToInt32(cbBanco.Text[0].ToString());
            conta.ClienteId = Convert.ToInt32(cbCliente.Text[0].ToString());
            contaRepository.Inserir(conta);
            MessageBox.Show("Registro incluído com sucesso");
            Close();
        }
    }
}
