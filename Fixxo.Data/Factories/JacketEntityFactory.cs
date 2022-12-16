using Fixxo.Data.Entities;

namespace Fixxo.Data.Factories
{
    public static class JacketEntityFactory
    {
        public static JacketEntity Create(string category, string name, int rating, decimal price)
        {
            return new JacketEntity
            {
                Category = category,
                Name = name,
                Rating = rating,
                Price = price,
            };
        }
    }
}
