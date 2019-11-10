using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class FornecedorMap : EntityTypeConfiguration<Fornecedor>
    { 
        public FornecedorMap()
        {
            ToTable("Fornecedor");

            HasKey(c => c.Id);

            Property(c => c.Nome).IsRequired().HasMaxLength(60);
            //Property(c => c.DtaRecebimento).IsRequired();
            Property(c => c.Ativo).IsRequired();
            //Property(c => c.QtdRecebida).IsRequired();

        }
    }
}
