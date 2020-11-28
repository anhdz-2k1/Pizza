using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string Category { get; set; }
        public long PriceSizeID { get; set; }

        public virtual PriceSize PriceSize { get; set; }
    }
}
