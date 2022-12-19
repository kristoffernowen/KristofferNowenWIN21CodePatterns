using Fixxo.Core.Models;

namespace Fixxo.MVC.Models.OutputDto.Shoes;

public static class GetShoesOutputDtoExtensions
{
    public static GetShoesOutputDto ToDto(this Shoes model)
    {
        return new GetShoesOutputDto
        {
            Category = model.Category,
            Id = model.Id,
            CatalogItemId = model.CatalogItemId,
            Name = model.Name,
            Rating = model.Rating,
            Price = model.Price,
            MaxSize = model.MaxSize,
            ImgUrl = model.ImgUrl
        };
    }
}