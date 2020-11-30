using System.Collections.Generic;
using System.Linq;

namespace Pizza.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem(Product product, PriceSize priceSize, int quantity)
        {
            CartLine line = Lines
                .Where(p => p.Product.ProductID == product.ProductID).Where(p => p.PriceSize.ID == priceSize.ID)
                .FirstOrDefault();
            if(line == null)
            {
                Lines.Add(new CartLine
                {
                    Product = product,
                    PriceSize = priceSize,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Product product, PriceSize priceSize)
            => Lines.RemoveAll(l => l.Product.ProductID == product.ProductID && l.PriceSize.ID == priceSize.ID);

        public decimal ComputeTotalValue()
            => Lines.Sum(e => e.PriceSize.Price * e.Quantity);

        public void Clear()
            => Lines.Clear();
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public PriceSize PriceSize { get; set; }
        public int Quantity { get; set; }
    }
}
