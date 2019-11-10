using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    interface IEstoqueRepository : IBaseRepository<Estoque>
    {
        void AtualizaSaldoEntrada(int Id, int Qtde);

        Boolean AtualizaSaldoSaida(int Id, int Qtde);
    }
}
