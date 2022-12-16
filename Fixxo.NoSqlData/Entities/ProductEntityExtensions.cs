using Fixxo.Core.Models;

namespace Fixxo.Data.Entities;

public static class ProductEntityExtensions
{
    public static Product ToModel(this ProductEntity entity)
    {
        // Ingen factory, för det blir nog bara här den initieras ändå. Så det känns som att jag beaktar DIP tillräckligt
        // Jag gjorde factory på modellerna i core för att testa

        return new Product()
        {
            Category = entity.Category,
            Name = entity.Name,
            Price = entity.Price,
            Rating = entity.Rating
        };
    }
}