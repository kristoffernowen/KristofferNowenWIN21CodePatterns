using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models.Enums;

namespace Fixxo.Core.Models
{
    public class Boots : Product, IBoots, IProduct
    {
        // public string Category { get; set; } = null!;
        // public string Name { get; set; } = null!;
        // public int Rating { get; set; }
        // public decimal Price { get; set; }
        public int MaxSize { get; set; }
        public int MinSize { get; set; }
        public bool IsKneeHigh { get; set; }
        public Season Season { get; set; }
    }
}
