using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizza.Models
{
    public class PriceSize
    {
        public long ID { get; set; }
        public string Size { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
