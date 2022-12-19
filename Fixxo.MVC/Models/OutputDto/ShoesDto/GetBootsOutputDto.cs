using Fixxo.MVC.Interfaces.Models.OutputDto;

namespace Fixxo.MVC.Models.OutputDto.ShoesDto;

public class GetBootsOutputDto: IGetShoesOutputDto, IGetBootsOutputDto
{
    public int MaxSize { get; set; }
    public string Id { get; set; }
    public string Category { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    public decimal Price { get; set; }
    public Guid CatalogItemId { get; set; }
    public string ImgUrl { get; set; }
    public bool isKneeHigh { get; set; }
    public string Season { get; set; }
}