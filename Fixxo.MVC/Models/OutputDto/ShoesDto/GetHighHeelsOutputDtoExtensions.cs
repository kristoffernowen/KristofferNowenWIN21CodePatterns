using Fixxo.Core.Models;

namespace Fixxo.MVC.Models.OutputDto.ShoesDto;

public static class GetHighHeelsOutputDtoExtensions
{
    public static GetHighHeelsOutputDto ToDto(this HighHeels model)
    {
        return new GetHighHeelsOutputDto
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