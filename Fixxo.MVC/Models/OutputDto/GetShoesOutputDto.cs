using Fixxo.Core.Models;

namespace Fixxo.MVC.Models.OutputDto
{
    public interface IGetShoesOutputDto
    {
        int MaxSize { get; set; }
        string Id { get; set; }
        string Category { get; set; }
        string Name { get; set; }
        int Rating { get; set; }
        decimal Price { get; set; }
        Guid CatalogItemId { get; set; }
        string ImgUrl { get; set; }
    }

    public class GetShoesOutputDto : GetProductOutputDto, IGetShoesOutputDto
    {
        public int MaxSize { get; set; }
    }

    public static class GetShoesOutputDtoExtensions
    {
        public static GetShoesOutputDto ToDto(this Shoes model)
        {
            return new GetShoesOutputDto
            {
                Category = model.Category,
                Id = model.Id,
                CatalogItemId = model.CatalogItemId,
                Name = model.Name,
                Rating = model.Rating,
                Price = model.Price,
                MaxSize = model.MaxSize,
                ImgUrl = model.ImgUrl
            };
        }
    }
}
