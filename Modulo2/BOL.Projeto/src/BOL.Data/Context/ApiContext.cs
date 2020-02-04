using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BOL.Busines.Model;
using BOL.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BOL.Data.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {

                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}