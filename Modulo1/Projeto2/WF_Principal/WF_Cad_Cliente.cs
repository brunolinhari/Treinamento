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
    public partial class WF_Cad_Cliente : Form
    {
        public ClienteRepository clienteRepository { get; set; }

        public IEnumerable<Cliente> Clientes { get; set; }

        public WF_Cad_Cliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteRepository clienteRepository = new ClienteRepository();
            Cliente cliente = new Cliente();
            cliente.Nome = edNome.Text;
            cliente.DataNascimento = edDtaNascimento.Value;
            clienteRepository.Inserir(cliente);
            MessageBox.Show("Registro incluído com sucesso");
            Close();
        }
    }
}
