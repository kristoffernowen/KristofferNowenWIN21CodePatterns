using System.ComponentModel.DataAnnotations;
using Fixxo.Data.Interfaces.Entities;

namespace Fixxo.Data.Entities
{
    public class ProductEntity : IProductEntity
    {
        [Key]
        public Guid Id { get; set; }

        public CatalogItemEntity CatalogItem { get; set; } = null!;
        
        public Guid CatalogItemId { get; set; }
        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; } = "https://images.pexels.com/photos/235621/pexels-photo-235621.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1";
    }
}
