using Fixxo.MVC.Interfaces;
using Fixxo.MVC.Interfaces.Models.OutputDto;

namespace Fixxo.MVC.Models.OutputDto.ShoesDto;


// Bygger vidare genom att förlänga med interface så jag inte behöver ändra GetShoesOutputDto enligt ocp.

public class GetBootsOutputDto: IGetShoesOutputDto, IGetBootsOutputDto, IGetDto
{
    public int MaxSize { get; set; } = 48;
    public int MinSize { get; set; } = 35;
    public string Id { get; set; } = null!;
    public string Category { get; set; } = null!;
    public string Name { get; set; } = null!;
    public int Rating { get; set; }
    public decimal Price { get; set; }
    public Guid CatalogItemId { get; set; }
    public string ImgUrl { get; set; } = null!;
    public bool IsKneeHigh { get; set; } = true;
    public string Season { get; set; } = "Winter";
}

// hårdkodar så man ser, hinner inte ha funktion