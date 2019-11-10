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
    public partial class WF_Caixa_Eletronico : Form
    {
        public ContaRepository contaRepository { get; set; }

        Conta conta = new Conta();
        Conta contaDestino = new Conta();

        public WF_Caixa_Eletronico()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            conta = contaRepository.Obter(Convert.ToInt32(edSqConta.Text));
            if ((conta.Saldo + conta.Limite) >= Convert.ToDecimal(edSqValor.Text))
            {
                contaRepository.RealizarSaque(conta, Convert.ToDecimal(edSqValor.Text));
                MessageBox.Show("Saque realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente!");
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            conta = contaRepository.Obter(Convert.ToInt32(edDpConta.Text));
            if (conta != null)
            {
                contaRepository.RealizarDeposito(conta, Convert.ToDecimal(edDpValor.Text));
                MessageBox.Show("Depósito realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Conta não encontrada");
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            conta = contaRepository.Obter(Convert.ToInt32(edTrOrigem.Text));
            contaDestino = contaRepository.Obter(Convert.ToInt32(edTrDestino.Text));
            contaRepository.RealizarTransferencia(conta, contaDestino, Convert.ToDecimal(edDpValor.Text));
            MessageBox.Show("Transferência realizada com sucesso!");
        }
    }
}
