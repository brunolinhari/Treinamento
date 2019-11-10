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
    public partial class FCliente : Form
    {
        public ClienteRepository clienteRepository { get; set; }
        public IEnumerable<Cliente> Clientes { get; set; }

        public FCliente()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            clienteRepository = new ClienteRepository();
            Clientes = new List<Cliente>();
            Clientes = clienteRepository.Obter().ToList();
            cbCliente.DataSource = null;
            cbCliente.DataSource = Clientes;
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "Id";
            cbCliente.SelectedIndex = -1;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FCliente_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteRepository clienteRepository = new ClienteRepository();
            Cliente cliente = new Cliente();
            cliente.Nome = cbCliente.Text;
            cliente.DataNascimento = edDtaNascimento.Value;
            if (edId.Text == "")
            {
                clienteRepository.Inserir(cliente);
                MessageBox.Show("Registro incluído com sucesso");
            }
            else
            {
                cliente.Id = Convert.ToInt32(edId.Text);
                clienteRepository.Editar(cliente);
                MessageBox.Show("Registro alterado com sucesso");
            }
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (edId.Text != "")
            {
                clienteRepository.Apagar(Convert.ToInt32(edId.Text));
                MessageBox.Show("Registro excliído com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Informe o cliente");
            }
        }

        private void cbCliente_DropDownClosed(object sender, EventArgs e)
        {
            if (cbCliente.SelectedIndex >= 0)
            {
                edId.Text = cbCliente.SelectedValue.ToString();
                Cliente cliente = clienteRepository.Obter(Convert.ToInt32(edId.Text));
                edDtaNascimento.Value = cliente.DataNascimento;

            }        }
    }
}
