using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class Venda : Entity
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public decimal VlUnitario { get; set; }
        public int Qtde { get; set; }
        public decimal VlTotal { get; set; }
        public string DescCliente => Cliente.Nome;
        public string DescProduto => Produto.Descricao;

    }
}
