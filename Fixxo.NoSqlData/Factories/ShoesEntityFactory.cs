using Fixxo.Data.Entities;

namespace Fixxo.NoSqlData.Factories;

public static class ShoesEntityFactory
{
    public static ShoesEntity Create(string category, string name, int rating, decimal price, int size)
    {
        return new ShoesEntity()
        {
            Category = category,
            Name = name,
            Rating = rating,
            Price = price,
            Size = size
        };
    }
}