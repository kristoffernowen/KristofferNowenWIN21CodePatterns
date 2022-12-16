using Fixxo.Core.Models;

namespace Fixxo.Core.Factories
{
    public static class ShoesFactory
    {
        public static Shoes Create(string category, string name, int rating, decimal price)
        {
            return new Shoes
            {
                Category = category,
                Name = name,
                Price = price,
                Rating = rating
            };
        }
    }
}
