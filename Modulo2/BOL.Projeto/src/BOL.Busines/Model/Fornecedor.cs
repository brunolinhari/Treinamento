using System.Collections.Generic;

namespace BOL.Busines.Model
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public bool ativo { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}