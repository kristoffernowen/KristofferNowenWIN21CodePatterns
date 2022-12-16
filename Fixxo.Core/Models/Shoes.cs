namespace Fixxo.Core.Models;

public class Shoes : Product
{
    public string Category { get; set; } = null!;
    public string Name { get; set; } = null!;
    public int Rating { get; set; }
    public decimal Price { get; set; }
}