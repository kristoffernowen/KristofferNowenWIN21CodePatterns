using Fixxo.Core.Interface.Models;

namespace Fixxo.Core.Models;

public class Jacket : ProductInCatalog, IJacket
{
    public string AvailableSizes { get; set; } = null!;
}