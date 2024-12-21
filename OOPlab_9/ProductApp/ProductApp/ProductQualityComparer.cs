using System.Collections.Generic;

class ProductQualityComparer : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        return x.Quality.CompareTo(y.Quality);
    }
}
