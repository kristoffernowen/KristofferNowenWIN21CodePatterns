using Fixxo.Core.Models;

namespace Fixxo.Core.Factories
{
    public static class JacketFactory
    {
        public static Jacket Create(string category, string name, int rating, decimal price)
        {
            return new Jacket
            {
                Category = category,
                Name = name,
                Price = price,
                Rating = rating
            };
        }
    }
}
