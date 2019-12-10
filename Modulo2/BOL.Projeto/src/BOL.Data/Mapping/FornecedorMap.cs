using BOL.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BOL.Data.Mapping
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Nome).IsRequired().HasColumnType("varchar(200)");

            builder.Property(p => p.Documento).IsRequired().HasColumnType("varchar(14)");

            builder.HasMany(f => f.Produtos).WithOne(p => p.Fornecedor).HasForeignKey(p => p.FornecedorId);

            builder.ToTable("Fornecedores");
        }
    }
}