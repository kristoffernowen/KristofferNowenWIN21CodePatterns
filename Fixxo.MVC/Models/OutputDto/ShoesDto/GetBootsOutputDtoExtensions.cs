using Fixxo.Core.Models;

namespace Fixxo.MVC.Models.OutputDto.ShoesDto;

public static class GetBootsOutputDtoExtensions
{
    public static GetBootsOutputDto ToDto(this Boots model)
    {
        return new GetBootsOutputDto
        {
            Category = model.Category,
            Id = model.Id,
            CatalogItemId = model.CatalogItemId,
            Name = model.Name,
            Rating = model.Rating,
            Price = model.Price,
            ImgUrl = model.ImgUrl
        };
    }
}