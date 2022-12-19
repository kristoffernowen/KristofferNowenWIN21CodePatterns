namespace Fixxo.Core.Interface.Models;

public interface IShoes
{
    public string Category { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    public decimal Price { get; set; }
    public int MaxSize { get; set; }
    public int MinSize { get; set; }
}