using Fixxo.Core.Models;

namespace Fixxo.Data.Entities;

public static class ProductEntityExtensions
{
    public static Product ToModel(this ProductEntity entity)
    {
        return new Product()
        {
            Category = entity.Category,
            Name = entity.Name,
            Price = entity.Price,
            Rating = entity.Rating
        };
    }
}