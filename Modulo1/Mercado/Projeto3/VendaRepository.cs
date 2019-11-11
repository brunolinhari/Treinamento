using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class VendaRepository : BaseRepository<Venda>
    {
        public override IEnumerable<Venda> Obter()
        {
            return Context.Vendas.Include("Cliente").Include("Produto").ToList();
        }

        public override Venda Obter(int Id)
        {
            return Context.Vendas.Include("Cliente").Include("Produto").Where(a => a.Id == Id).FirstOrDefault();
        }
    }
}
