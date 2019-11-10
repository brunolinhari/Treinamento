using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class PedidoRepository : BaseRepository<Pedido>
    {
        public override IEnumerable<Pedido> Obter()
        {
            return Context.Pedidos.Include("Fornecedor").Include("Produto").ToList();
        }

        public override Pedido Obter(int Id)
        {
            return Context.Pedidos.Include("Fornecedor").Include("Produto").Where(a => a.Id == Id).FirstOrDefault();
        }
    }
}
