using Fixxo.Core.Factories;
using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;

namespace Fixxo.MVC.Models.OutputDto;

public static class GetProductOutputDtoExtensions
{
    public static GetProductOutputDto ToDto(this Product model)
    {
        // Ingen factory, för det blir nog bara här den initieras ändå. Så det känns som att jag beaktar DIP tillräckligt
        // Jag gjorde factory på modellerna i core för att testa

        if (model != null)
        {
            return new GetProductOutputDto
            {
                Category = model.Category,
                Name = model.Name,
                Price = model.Price,
                Rating = model.Rating,
                CatalogItemId = model.CatalogItemId,
                ImgUrl = model.ImgUrl
            };
        }
        
        return new GetProductOutputDto
        {
            Category = "I am not a product",
            Name = "I should not be here",
            Rating = 1,
            Price = 0
        };
    }
}