using Fixxo.Core.Models;

namespace Fixxo.Core.Factories
{
    public static class ProductFactory
    {
        public static ProductInCatalog CreateProduct(string category, string name, decimal price, int rating, string imgUrl)
        {
            return new ProductInCatalog
            {
                Category = category,
                Name = name,
                Price = price,
                Rating = rating,
                ImgUrl = imgUrl
            };
        }
    }
}
