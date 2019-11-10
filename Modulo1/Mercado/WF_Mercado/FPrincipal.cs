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
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FCliente frmCad_Cliente = new FCliente();
            frmCad_Cliente.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FProduto frmCad_Produto = new FProduto();
            frmCad_Produto.ShowDialog();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            FFornecedor frmCad_Fornecedor = new FFornecedor();
            frmCad_Fornecedor.ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FPedido frmPedido = new FPedido();
            frmPedido.ShowDialog();
        }
    }
}
