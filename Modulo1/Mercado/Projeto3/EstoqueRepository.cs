using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class EstoqueRepository : BaseRepository<Estoque>, IEstoqueRepository
    {
        //public ProdutoRepository produtoRepository { get; set; }

        public void AtualizaSaldoEntrada(int Id, int Qtde)
        {
            Estoque estoque = new Estoque();
            //Estoque estoque = Obter(Id);
            estoque = Obter(Id);
            if (estoque == null)
            {
                estoque.Id = Id;
                estoque.Saldo = Qtde;
                if (Qtde > 3)
                {
                    estoque.Minimo = Qtde - 3;
                }
                else
                {
                    estoque.Minimo = 1;
                }
                Inserir(estoque);
            }
            else
            {
                estoque.Saldo = estoque.Saldo + Qtde;
                Editar(estoque);
            }
        }

        public Boolean AtualizaSaldoSaida(int Id, int Qtde)
        {
            Estoque estoque = Obter(Id);
            if (estoque == null)
            {
                return false;
            }
            else
            {
                if (estoque.Saldo < Qtde)
                {
                    return false;
                }
                else
                {
                    estoque.Saldo = estoque.Saldo - Qtde;
                    Editar(estoque);
                    return true;
                }
            }
        }
    }
}
