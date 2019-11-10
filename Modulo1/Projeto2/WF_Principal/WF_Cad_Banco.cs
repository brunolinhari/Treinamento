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
    public partial class WF_Cad_Banco : Form
    {
        public BancoRepository bancoRepository { get; set; }

        public IEnumerable<Banco> Bancos { get; set; }

        public WF_Cad_Banco()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            BancoRepository bancoRepository = new BancoRepository();
            Banco banco = new Banco();
            banco.Nome = edNome.Text;
            banco.Codigo = Convert.ToInt32(edCodigo.Text);
            bancoRepository.Inserir(banco);
            MessageBox.Show("Registro incluído com sucesso");
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
