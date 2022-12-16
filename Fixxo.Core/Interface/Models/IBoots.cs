namespace Fixxo.Core.Interface.Models;

public interface IBoots : IShoes
{
    string Category { get; set; }
    string Name { get; set; }
    int Rating { get; set; }
    decimal Price { get; set; }
    bool IsKneeHigh { get; set; }
}