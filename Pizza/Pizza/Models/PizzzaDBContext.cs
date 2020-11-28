using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pizza.Models
{
    public class PizzzaDBContext : DbContext
    {
        public PizzzaDBContext(DbContextOptions<PizzzaDBContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<PriceSize> PriceSizes { get; set; }

    }
}
