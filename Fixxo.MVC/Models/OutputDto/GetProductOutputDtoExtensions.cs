using Fixxo.Core.Models;

namespace Fixxo.MVC.Models.OutputDto;

public static class GetProductOutputDtoExtensions
{
    public static GetProductOutputDto ToDto(this Product model)
    {
        return new GetProductOutputDto
        {
            Category = model.Category,
            Name = model.Name,
            Price = model.Price,
            Rating = model.Rating
        };
    }
}