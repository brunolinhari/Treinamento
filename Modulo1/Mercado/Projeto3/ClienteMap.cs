using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("cliente");

            HasKey(c => c.Id);

            Property(c => c.Nome).IsRequired().HasMaxLength(60);
            Property(c => c.DataNascimento).IsRequired();
        }
    }
}
