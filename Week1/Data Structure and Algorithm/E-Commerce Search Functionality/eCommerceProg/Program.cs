using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceSearchVS
{
    public class Product
    {
        public int ProductId { get; }
        public string ProductName { get; }
        public string Category { get; }

        public Product(int id, string name, string category)
        {
            ProductId = id;
            ProductName = name;
            Category = category;
        }
    }

    class Program
    {
        static void Main()
        {
            Product[] products = new Product[]
            {
                new Product(101, "Book", "Education"),
                new Product(102, "Headphones", "Electronics"),
                new Product(103, "Backpack", "Accessories"),
                new Product(104, "Notebook", "Stationery"),
                new Product(105, "Pen", "Stationery")
            };

            Console.WriteLine("=== E-Commerce Product Search ===");
            Console.Write("Enter product name to search: ");
            string searchTerm = Console.ReadLine();

            Console.WriteLine("\n Linear Search:");
            Product linearResult = LinearSearch(products, searchTerm);
            PrintResult(linearResult);

            Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

            Console.WriteLine("\n Binary Search:");
            Product binaryResult = BinarySearch(products, searchTerm);
            PrintResult(binaryResult);

            Console.WriteLine("\n=== Search Complete ===");
        }

        static Product LinearSearch(Product[] products, string name)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return product;
            }
            return null;
        }

        static Product BinarySearch(Product[] products, string name)
        {
            int left = 0, right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = string.Compare(products[mid].ProductName, name, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return products[mid];
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }

        static void PrintResult(Product product)
        {
            if (product != null)
            {
                Console.WriteLine($"Found: {product.ProductName}");
                Console.WriteLine($"ID: {product.ProductId}");
                Console.WriteLine($"Category: {product.Category}");
            }
            else
            {
                Console.WriteLine(" Product not found.");
            }
        }
    }
}
