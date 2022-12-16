using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixxo.Core.Interface.Models;

namespace Fixxo.Data.Entities
{
    public class ProductEntity : IProduct
    {
        // [Key] public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
    }
}
