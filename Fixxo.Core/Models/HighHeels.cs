using Fixxo.Core.Interface.Models;

namespace Fixxo.Core.Models
{
    public class HighHeels : Product, IHighHeels, IProduct
    {
        // public string Category { get; set; } = null!;
        // public string Name { get; set; } = null!;
        // public int Rating { get; set; }
        // public decimal Price { get; set; }
        public int MaxSize { get; set; }
        public int MinSize { get; set; }
        public int HeightOfHeels { get; set; }
        

    }
}
