using Projeto2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaRepository repository = new ContaRepository();

            #region InserirConta
            Conta conta = new Conta();
            conta.Limite = 100;
            conta.Saldo = 1000;
            conta.ContaCorrente = "123456";
            conta.Agencia = "123";
            //conta.Banco = "Itaú";

            //repository.Inserir(conta);

            #endregion        }

            #region Editar Conta
            Conta contaEditar = new Conta();
            contaEditar.Id = 3;
            contaEditar.Limite = 100;
            contaEditar.Saldo = 1000;
            contaEditar.ContaCorrente = "123456";
            contaEditar.Agencia = "123";
            //contaEditar.Banco = "Itaú";

            //repository.Editar(contaEditar);
            #endregion

            #region Apagar Conta
            //repository.Apagar(2);
            #endregion

            #region Ralizar Saque
            Conta contaSaque = repository.Obter(1);

            repository.RealizarSaque(contaSaque, 10);
            #endregion

            #region Ralizar Deposito
            Conta contaDeposito = repository.Obter(2);

            repository.RealizarSaque(contaDeposito, 20);
            #endregion

            #region Ralizar Transferencia
            Conta contaOrigem = repository.Obter(3);
            Conta contaDestino = repository.Obter(4);

            repository.RealizarTransferencia(contaOrigem, contaDestino, 10);
            #endregion

            #region Obter apenas uma Conta
            Conta conta_1 = repository.Obter(1);
            Console.WriteLine(conta_1);
            #endregion

            #region Obter Todas as Contas
            IEnumerable<Conta> contas = repository.Obter();

            foreach (var item in contas)
            {
                Console.Write(item.Saldo + " - ");
                Console.Write(item.Limite + " - ");
                Console.Write(item.Agencia + " - ");
                Console.WriteLine(item.ContaCorrente);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
