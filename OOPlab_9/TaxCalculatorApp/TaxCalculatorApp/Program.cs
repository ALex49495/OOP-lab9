class Program
{
    static void Main(string[] args)
    {
        List<ITaxCalculator> taxes = new List<ITaxCalculator>
        {
            new LandTax(),
            new CarTax(),
            new IncomeTax()
        };

        foreach (var tax in taxes)
        {
            Console.WriteLine(tax.CalculateTax());
        }

        List<Product> products = new List<Product>
        {
            new Product { Name = "Product1", Weight = 1.2, Price = 100, Quality = 90 },
            new Product { Name = "Product2", Weight = 2.5, Price = 200, Quality = 80 },
            new Product { Name = "Product3", Weight = 0.5, Price = 150, Quality = 85 }
        };

        products.Sort();
        Console.WriteLine("Products sorted by weight:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name}: {product.Weight}");
        }

        products.Sort(new ProductPriceComparer());
        Console.WriteLine("Products sorted by price:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name}: {product.Price}");
        }

        products.Sort(new ProductQualityComparer());
        Console.WriteLine("Products sorted by quality:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name}: {product.Quality}");
        }
    }
}
