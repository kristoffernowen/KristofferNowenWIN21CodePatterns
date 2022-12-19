using Fixxo.Data.Entities.ShoesEntities;

namespace Fixxo.Data.Factories;

public static class HighHeelsEntityFactory
{
    public static HighHeelsEntity Create(string category, string name, int rating, decimal price, string imgUrl, Guid catalogItemId)
    {
        return new HighHeelsEntity
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