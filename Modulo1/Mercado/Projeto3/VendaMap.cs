using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class VendaMap : EntityTypeConfiguration<Venda>
    {
        public VendaMap()
        {
            ToTable("Venda");

            HasKey(c => c.Id);

            Property(c => c.VlUnitario).IsRequired();
            Property(c => c.Qtde).IsRequired();
            Property(c => c.VlTotal).IsRequired();

//            HasRequired(s => s.Produto)
//                .WithMany(a => a.Vendas)
//                .HasForeignKey<int>(c => c.ProdutoId);
//
//            HasRequired(s => s.Cliente)
//                .WithMany(a => a.Vendas)
//                .HasForeignKey<int>(c => c.ClienteId);
        }
    }
}
