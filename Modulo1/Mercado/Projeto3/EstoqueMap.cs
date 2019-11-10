using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class EstoqueMap : EntityTypeConfiguration<Estoque>
    {
        public EstoqueMap()
        {
            ToTable("Estoque");

            HasKey(c => c.Id);

            Property(c => c.Saldo).IsRequired();
            Property(c => c.Minimo).IsRequired();

            HasRequired(p => p.Produto).WithOptional(e => e.Estoque);
        }
    }
}
