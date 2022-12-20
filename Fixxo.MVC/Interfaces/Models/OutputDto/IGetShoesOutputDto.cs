namespace Fixxo.MVC.Interfaces.Models.OutputDto;

public interface IGetShoesOutputDto
{
    public int MaxSize { get; set; }
    public int MinSize { get; set; }
    public string Id { get; set; }
    public string Category { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    public decimal Price { get; set; }
    public Guid CatalogItemId { get; set; }
    public string ImgUrl { get; set; }
}