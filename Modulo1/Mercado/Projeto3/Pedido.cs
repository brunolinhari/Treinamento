using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class Pedido : Entity
    {
        public int Numero { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        //public ICollection<Produto> Produtos { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int FornecedorId { get; set; }
        public DateTime DtaRecebimento { get; set; }
        public decimal VlUnitario { get; set; }
        public int QtdRecebida { get; set; }
        public decimal VlTotal { get; set; }
        public string DescFornecedor => Fornecedor.Nome;
        public string DescProduto => Produto.Descricao;
    }
}
