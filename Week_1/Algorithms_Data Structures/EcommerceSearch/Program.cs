using System;
using System.Linq;

namespace EcommerceSearch
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public Product(int productId, string productName, string category)
        {
            ProductId = productId;
            ProductName = productName;
            Category = category;
        }

        public override string ToString()
        {
            return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
        }
    }

    public static class ProductSearch
    {
        public static Product LinearSearch(Product[] products, string productName)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                    return product;
            }
            return null;
        }

        public static Product BinarySearch(Product[] sortedProducts, string productName)
        {
            int left = 0, right = sortedProducts.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = string.Compare(sortedProducts[mid].ProductName, productName, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return sortedProducts[mid];
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "T-shirt", "Clothing"),
                new Product(3, "Smartphone", "Electronics"),
                new Product(4, "Book", "Stationery"),
                new Product(5, "Shoes", "Footwear")
            };

            Console.WriteLine("Searching with Linear Search:");
            var result1 = ProductSearch.LinearSearch(products, "Book");
            Console.WriteLine(result1 != null ? result1.ToString() : "Product not found");

            Console.WriteLine("\nSorting products by name for Binary Search...");
            var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();

            Console.WriteLine("Searching with Binary Search:");
            var result2 = ProductSearch.BinarySearch(sortedProducts, "Book");
            Console.WriteLine(result2 != null ? result2.ToString() : "Product not found");

            Console.WriteLine("\n--- Analysis ---");
            Console.WriteLine("Linear Search Time Complexity: O(n)");
            Console.WriteLine("Binary Search Time Complexity: O(log n)");
            Console.WriteLine("Binary Search is more efficient for large sorted datasets.");
        }
    }
}
