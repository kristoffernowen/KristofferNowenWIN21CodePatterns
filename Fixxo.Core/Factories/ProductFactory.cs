using Fixxo.Core.Models;

namespace Fixxo.Core.Factories
{
    public static class ProductFactory
    {
        public static Product CreateProduct(string category, string name, decimal price, int rating)
        {
            return new Product
            {
                Category = category,
                Name = name,
                Price = price,
                Rating = rating
            };
        }
    }
}
