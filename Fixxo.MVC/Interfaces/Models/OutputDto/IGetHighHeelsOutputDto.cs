namespace Fixxo.MVC.Interfaces.Models.OutputDto;

public interface IGetHighHeelsOutputDto
{
    int HeightOfHeels { get; set; }
    string Id { get; set; }
    string Category { get; set; }
    string Name { get; set; }
    int Rating { get; set; }
    decimal Price { get; set; }
    Guid CatalogItemId { get; set; }
    string ImgUrl { get; set; }
    int MaxSize { get; set; }
}