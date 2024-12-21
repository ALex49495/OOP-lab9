using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class ProductCollection : IEnumerable<Product>
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        return products.OrderBy(p => p.Price).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
