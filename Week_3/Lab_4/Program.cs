
using System;
using System.Threading.Tasks;

namespace RetailInventory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            // Creating Categories
            var electronics = new Category { Name = "Electronics" };
            var groceries = new Category { Name = "Groceries" };
            var clothing = new Category { Name = "Clothing" };
            var furniture = new Category { Name = "Furniture" };

            await context.Categories.AddRangeAsync(electronics, groceries, clothing, furniture);

            // Creating Products
            var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
            var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };
            var product3 = new Product { Name = "Smartphone", Price = 50000, Category = electronics };
            var product4 = new Product { Name = "Refrigerator", Price = 60000, Category = electronics };
            var product5 = new Product { Name = "T-Shirt", Price = 800, Category = clothing };
            var product6 = new Product { Name = "Jeans", Price = 1500, Category = clothing };
            var product7 = new Product { Name = "Dining Table", Price = 25000, Category = furniture };
            var product8 = new Product { Name = "Office Chair", Price = 7000, Category = furniture };
            var product9 = new Product { Name = "Milk Packet", Price = 50, Category = groceries };
            var product10 = new Product { Name = "Washing Machine", Price = 45000, Category = electronics };

            await context.Products.AddRangeAsync(product1, product2, product3, product4, product5, product6, product7, product8, product9, product10);

            // Saving to Database
            await context.SaveChangesAsync();

            Console.WriteLine("All Data Inserted Successfully!");
        }
    }
}
