namespace Fixxo.Core.Interface.Models;

public interface IJacket
{
    string Category { get; set; }
    string Name { get; set; }
    int Rating { get; set; }
    decimal Price { get; set; }
    public string AvailableSizes { get; set; }
}