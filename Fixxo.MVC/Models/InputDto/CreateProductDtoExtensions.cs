using Fixxo.Core.Models;
using Fixxo.Data.Entities;

namespace Fixxo.MVC.Models.InputDto;

public static class CreateProductDtoExtensions
{
    public static Product ToModel(this CreateProductInputDto dto)
    {
        var entity = new Product
        {
            Category = dto.Category,
            Name = dto.Name,
            Rating = dto.Rating,
            Price = dto.Price
        };

        return entity;
    }
}