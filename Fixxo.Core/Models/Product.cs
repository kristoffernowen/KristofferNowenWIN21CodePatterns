using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixxo.Core.Models
{
    public class Product
    {
        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
    }
}
