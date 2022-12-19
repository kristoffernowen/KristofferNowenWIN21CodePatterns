using Fixxo.Data.Entities;

namespace Fixxo.Data.Interfaces.Entities;

public interface IProductEntity
{
    public Guid Id { get; set; }
    public CatalogItemEntity CatalogItem { get; set; }
    public Guid CatalogItemId { get; set; }
    public string Category { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    public decimal Price { get; set; }
    public string ImgUrl { get; set; }
}