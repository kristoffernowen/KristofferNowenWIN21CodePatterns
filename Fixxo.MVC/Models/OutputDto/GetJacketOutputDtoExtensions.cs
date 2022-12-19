using Fixxo.Core.Models;

namespace Fixxo.MVC.Models.OutputDto;

public static class GetJacketOutputDtoExtensions
{
    public static GetJacketOutputDto ToDto(this Jacket model)
    {
        return new GetJacketOutputDto
        {
            Category = model.Category,
            Id = model.Id,
            CatalogItemId = model.CatalogItemId,
            Name = model.Name,
            Rating = model.Rating,
            Price = model.Price,
            AvailableSizes = model.AvailableSizes,
            ImgUrl = model.ImgUrl
        };
    }

}