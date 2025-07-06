
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RetailInventory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            // Retrieve All Products
            var products = await context.Products.ToListAsync();
            Console.WriteLine("All Products:");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - ₹{p.Price}");
            }

            // Find by ID
            var product = await context.Products.FindAsync(1);
            Console.WriteLine($"\nProduct with ID 1: {product?.Name}");

            // First Product with Price > 50000
            var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
            Console.WriteLine($"\nExpensive Product: {expensive?.Name}");
        }
    }
}
