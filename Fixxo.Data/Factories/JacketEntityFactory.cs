using Fixxo.Data.Entities;

namespace Fixxo.Data.Factories
{
    public static class JacketEntityFactory
    {
        public static JacketEntity Create(string category, string name, int rating, decimal price, string imgUrl, Guid catalogItemId)
        {
            return new JacketEntity
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
}
