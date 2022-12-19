using Fixxo.Data.Entities.ShoesEntities;

namespace Fixxo.Data.Factories;

public static class BootsEntityFactory
{
    public static BootsEntity Create(string category, string name, int rating, decimal price, string imgUrl)
    {
        return new BootsEntity
        {
            Category = category,
            Name = name,
            Rating = rating,
            Price = price,
            ImgUrl = imgUrl
        };
    }
}