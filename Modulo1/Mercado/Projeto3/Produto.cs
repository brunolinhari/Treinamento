using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class Produto : Entity
    {
        //public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal VlCompra { get; set; }
        public decimal Lucro { get; set; }
        public decimal VlVenda { get; set; }
        public Boolean Ativo { get; set; }
        public Estoque Estoque { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        //public Pedido Pedido { get; set; }
        //public ICollection<Fornecedor> Fornecedores { get; set; }
    }
}
