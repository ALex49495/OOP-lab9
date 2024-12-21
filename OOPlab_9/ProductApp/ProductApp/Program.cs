using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        ProductCollection products = new ProductCollection();
        products.AddProduct(new Product { Name = "Product1", Weight = 1.2, Price = 100, Quality = 90 });
        products.AddProduct(new Product { Name = "Product2", Weight = 2.5, Price = 200, Quality = 80 });
        products.AddProduct(new Product { Name = "Product3", Weight = 0.5, Price = 150, Quality = 85 });
        products.AddProduct(new Product { Name = "Product4", Weight = 2.0, Price = 120, Quality = 95 });

        Console.WriteLine("Products sorted by weight:");
        foreach (var product in products.OrderBy(p => p.Weight))
        {
            Console.WriteLine($"{product.Name}: {product.Weight}");
        }

        Console.WriteLine("Products sorted by price:");
        foreach (var product in products.OrderBy(p => p.Price))
        {
            Console.WriteLine($"{product.Name}: {product.Price}");
        }

        Console.WriteLine("Products sorted by quality:");
        foreach (var product in products.OrderBy(p => p.Quality))
        {
            Console.WriteLine($"{product.Name}: {product.Quality}");
        }
    }
}
