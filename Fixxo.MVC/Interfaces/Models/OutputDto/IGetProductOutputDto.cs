namespace Fixxo.MVC.Interfaces.Models.OutputDto;

public interface IGetProductOutputDto
{
    public string Id { get; set; }
    public string Category { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    public decimal Price { get; set; }
    public Guid CatalogItemId { get; set; }
    public string ImgUrl { get; set; }
}