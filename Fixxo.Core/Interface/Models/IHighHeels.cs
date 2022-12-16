namespace Fixxo.Core.Interface.Models;

public interface IHighHeels : IShoes
{
    string Category { get; set; }
    string Name { get; set; }
    int Rating { get; set; }
    decimal Price { get; set; }
    int HeightOfHeels { get; set; }
}