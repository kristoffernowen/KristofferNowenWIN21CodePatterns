namespace Fixxo.Data.Entities;

internal interface IHighHeelsEntity
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
    int HeightOfHeels { get; set; }
}