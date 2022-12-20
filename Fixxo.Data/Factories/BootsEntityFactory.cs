using Fixxo.Data.Entities.ShoesEntities;

namespace Fixxo.Data.Factories;

public static class BootsEntityFactory
{
    public static BootsEntity Create(string category, string name, int rating, decimal price, string imgUrl, Guid catalogItemId)
    {
        imgUrl ??=
            "https://images.pexels.com/photos/235621/pexels-photo-235621.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1";

        return new BootsEntity
        {
            Category = category,
            Name = name,
            Rating = rating,
            Price = price,
            ImgUrl = imgUrl,
            CatalogItemId = catalogItemId
        };
    }
}