using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public interface IContaRepository : IBaseRepository<Conta>
    {
        void RealizarSaque(Conta conta, decimal valor);

        void RealizarDeposito(Conta conta, decimal valor);

        void RealizarTransferencia(Conta contaOrigem, Conta contaDestino, decimal valor);

        Conta Obter(string agencia, string contaCorrente);

        bool ExisteSaldo(int Id, decimal valor);
    }
}
