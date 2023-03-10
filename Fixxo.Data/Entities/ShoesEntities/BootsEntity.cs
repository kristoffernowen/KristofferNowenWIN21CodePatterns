using Fixxo.Core.Models.Enums;
using Fixxo.Data.Interfaces.Entities.ShoeEntities;

namespace Fixxo.Data.Entities.ShoesEntities
{
    public class BootsEntity : IBootsEntity, IShoesEntity
    {
        public int MaxSize { get; set; }
        public int MinSize { get; set; }
        public Guid Id { get; set; }
        public CatalogItemEntity CatalogItem { get; set; } = null!;
        public Guid CatalogItemId { get; set; }
        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public string? ImgUrl { get; set; } = null!;
        public bool IsKneeHigh { get; set; } = true;
        public Season Season { get; set; } = Season.Winter;
    }
}
