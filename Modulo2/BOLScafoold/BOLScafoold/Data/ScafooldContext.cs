using BOLScafoold.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOLScafoold.Data
{
    public class ScafooldContext : DbContext
    {
        public ScafooldContext(DbContextOptions<ScafooldContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
