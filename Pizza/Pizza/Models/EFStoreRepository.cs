using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private PizzzaDBContext context;
        public EFStoreRepository(PizzzaDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
        public IQueryable<PriceSize> PriceSizes => context.PriceSizes;
    }
}
