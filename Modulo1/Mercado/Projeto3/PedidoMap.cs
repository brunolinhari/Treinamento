using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class PedidoMap : EntityTypeConfiguration<Pedido>
    {
        public PedidoMap()
        {
            ToTable("Pedido");

            HasKey(c => c.Id);
            
            Property(c => c.Numero).IsRequired();
            Property(c => c.QtdRecebida).IsRequired();
            Property(c => c.VlUnitario).IsRequired();
            Property(c => c.VlTotal).IsRequired();

            HasRequired(s => s.Produto)
                .WithMany(a => a.Pedidos)
                .HasForeignKey<int>(c => c.ProdutoId);

            HasRequired(s => s.Fornecedor)
                .WithMany(a => a.Pedidos)
                .HasForeignKey<int>(c => c.FornecedorId);
        }
    }
}
