using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Pizza.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            PizzzaDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<PizzzaDBContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.PriceSizes.Any())
            {
                context.PriceSizes.AddRange(
                    new PriceSize
                    {
                        Price = 180000,
                        Size = "M"
                    }
                );
                context.SaveChanges();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "DOUBLE CHEESE BURGER",
                        Description = "Tôm, sò điệp, cua thanh, hành tây, nấm với xốt ớt chua ngọt và phomát.",
                        Img = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Pizza-Double-Cheese-Burger.jpg",
                        Category = "Pizza",
                        PriceSizeID = 1
                        
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
