using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class EstoqueRepository : BaseRepository<Estoque>
    {
     //   public Projeto3Context Context { get; set; }
        public override IEnumerable<Estoque> Obter()
        {
            return Context.Estoques.Include("Produto").ToList();
        }

        public override Estoque Obter(int Id)
        {
            return Context.Estoques.Include("Produto").Where(a => a.Id == Id).FirstOrDefault();
        }


        //public EstoqueRepository()
        //{
        //    Context = new Projeto3Context();
        //}

//        public void AtualizaSaldoEntrada(int Id, int Qtde)
//        {
//            Estoque estoqueDB = Obter(Id);
//            if (estoqueDB == null)
//            {
//                int minimo = 1;
//                if (Qtde > 3)
//                {
//                    minimo = Qtde - 3;
//                }
//                Context.Database.ExecuteSqlCommand($"INSERT INTO Estoque (Id, Saldo, Minimo) VALUES ({Id}, {Qtde}, {minimo})");
//            }
//            else
//            {
//                Context.Database.ExecuteSqlCommand($"UPDATE Estoque SET saldo=saldo+{Qtde} WHERE id={Id}");
//            }
//        }
//
//        public Boolean AtualizaSaldoSaida(int Id, int Qtde)
//        {
//            Estoque estoqueDB = Obter(Id);
//            if (estoqueDB == null)
//            {
//                return false;
//            }
//            else
//            {
//                if (estoqueDB.Saldo < Qtde)
//                {
//                    return false;
//                }
//                else
//                {
//                    Context.Database.ExecuteSqlCommand($"UPDATE Estoque SET saldo=saldo-{Qtde} WHERE id={Id}");
//                    return true;
//                }
//
//            }
//
//        }
        public void AtualizaSaldoEntrada(int Id, int Qtde)
        {
            Estoque estoque = Obter(Id);
            if (estoque == null)
            {
                estoque = new Estoque();
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
                estoque.Saldo += Qtde;
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
