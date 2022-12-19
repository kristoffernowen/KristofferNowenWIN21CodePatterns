using Fixxo.MVC.Interfaces.Models.OutputDto;

namespace Fixxo.MVC.Models.OutputDto.ShoesDto;

public class GetHighHeelsOutputDto : IGetShoesOutputDto, IGetHighHeelsOutputDto
{
    public int HeightOfHeels { get; set; }
    public int MaxSize { get; set; }
    public string Id { get; set; }
    public string Category { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    public decimal Price { get; set; }
    public Guid CatalogItemId { get; set; }
    public string ImgUrl { get; set; }
}