using Fixxo.Data.Entities;

namespace Fixxo.Data.Interfaces.Entities.ShoeEntities;

public interface IShoesEntity
{
    int MaxSize { get; set; }
    Guid Id { get; set; }
    CatalogItemEntity CatalogItem { get; set; }
    Guid CatalogItemId { get; set; }
    string Category { get; set; }
    string Name { get; set; }
    int Rating { get; set; }
    decimal Price { get; set; }
    string ImgUrl { get; set; }
}