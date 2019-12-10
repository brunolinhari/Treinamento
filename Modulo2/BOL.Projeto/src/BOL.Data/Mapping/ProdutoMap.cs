using BOL.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BOL.Data.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Nome).IsRequired().HasColumnType("varchar(200)");

            builder.Property(p => p.Descricao).IsRequired().HasColumnType("varchar(1000)");

            builder.Property(p => p.Imagem).IsRequired().HasColumnType("varchar(100)");

            builder.ToTable("Produtos");
            
        }
    }
}