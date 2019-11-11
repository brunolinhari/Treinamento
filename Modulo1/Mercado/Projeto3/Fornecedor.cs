using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class Fornecedor : Entity
    {
        //public int Id { get; set; }
//        public Produto Produto { get; set; }
        public string Nome { get; set; }
        public Boolean Ativo { get; set; }
        //        public DateTime DtaRecebimento { get; set; }
        //        public int QtdRecebida { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
