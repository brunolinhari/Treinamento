using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class Projeto3Context : DbContext
    {
        public Projeto3Context() : base("conexao")
        {

        }
 
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Estoque> Estoques { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         

            modelBuilder.Properties<String>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new EstoqueMap());
            modelBuilder.Configurations.Add(new FornecedorMap());
            modelBuilder.Configurations.Add(new PedidoMap());

            base.OnModelCreating(modelBuilder);
        }

        internal object Set<T>(object entidadeDB)
        {
            throw new NotImplementedException();
        }
    }
}
