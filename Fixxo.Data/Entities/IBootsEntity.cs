using Fixxo.Core.Models.Enums;

namespace Fixxo.Data.Entities;

public interface IBootsEntity
{
    int MaxSize { get; set; }
    int MinSize { get; set; }
    Guid Id { get; set; }
    CatalogItemEntity CatalogItem { get; set; }
    Guid CatalogItemId { get; set; }
    string Category { get; set; }
    string Name { get; set; }
    int Rating { get; set; }
    decimal Price { get; set; }
    string ImgUrl { get; set; }
    bool IsKneeHigh { get; set; }
    Season Season { get; set; } 
}