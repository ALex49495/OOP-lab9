class Product : IComparable<Product>
{
    public string Name { get; set; } = string.Empty;
    public double Weight { get; set; }
    public double Price { get; set; }
    public int Quality { get; set; }

    public int CompareTo(Product? other)
    {
        if (other == null) return 1;
        return this.Weight.CompareTo(other.Weight);
    }
}
