using Fixxo.Core.Models;

namespace Fixxo.MVC.Models.OutputDto
{
    public interface IGetJacketOutputDto
    {
        string AvailableSizes { get; set; }
        string Id { get; set; }
        string Category { get; set; }
        string Name { get; set; }
        int Rating { get; set; }
        decimal Price { get; set; }
        Guid CatalogItemId { get; set; }
        string ImgUrl { get; set; }
    }

    public class GetJacketOutputDto : GetProductOutputDto, IGetJacketOutputDto
    {
        public string AvailableSizes { get; set; } = null!;
    }

    public static class GetJacketOutputDtoExtensions
    {
        public static GetJacketOutputDto ToDto(this Jacket model)
        {
            return new GetJacketOutputDto
            {
                Category = model.Category,
                Id = model.Id,
                CatalogItemId = model.CatalogItemId,
                Name = model.Name,
                Rating = model.Rating,
                Price = model.Price,
                AvailableSizes = model.AvailableSizes,
                ImgUrl = model.ImgUrl
            };
        }

    } 
}
