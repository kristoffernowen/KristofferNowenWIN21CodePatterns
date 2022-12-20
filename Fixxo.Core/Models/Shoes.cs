using Fixxo.Core.Interface.Models;

namespace Fixxo.Core.Models;

public class Shoes : Product, IShoes
{
    public int MaxSize { get; set; }
    public int MinSize { get; set; }
}