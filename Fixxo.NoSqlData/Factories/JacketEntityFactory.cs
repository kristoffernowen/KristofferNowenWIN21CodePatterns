using Fixxo.Data.Entities;

namespace Fixxo.NoSqlData.Factories
{
    public static class JacketEntityFactory
    {
        public static JacketEntity Create(string category, string name, int rating, decimal price, string size)
        {
            return new JacketEntity
            {
                Category = category,
                Name = name,
                Rating = rating,
                Price = price,
                Size = size
            };
        }
    }
}
