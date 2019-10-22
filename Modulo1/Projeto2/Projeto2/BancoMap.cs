using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class BancoMap : EntityTypeConfiguration<Banco>
    {
        public BancoMap()
        {
            ToTable("tab_banco");

            HasKey(c => c.Id);

            Property(c => c.Codigo).IsRequired();
            Property(c => c.Nome).IsRequired().HasMaxLength(60);
        }

    }
}
