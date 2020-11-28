using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class IStoreRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<PriceSize> PriceSizes { get; }
    }
}
