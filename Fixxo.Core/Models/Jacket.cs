using Fixxo.Core.Interface.Models;

namespace Fixxo.Core.Models;

public class Jacket : Product, IJacket
{
    public string AvailableSizes { get; set; }
}