using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("Produto");

            HasKey(c => c.Id);

            Property(c => c.Descricao).IsRequired().HasMaxLength(60);
            Property(c => c.VlCompra).IsRequired();
            Property(c => c.Lucro).IsRequired();
            Property(c => c.Ativo).IsRequired();
            Property(c => c.VlVenda).IsRequired();

            HasOptional(e => e.Estoque).WithRequired(p => p.Produto);
            //HasRequired(e => e.Pedidos).WithRequired(p => p.Produto);

        }
    }
}
