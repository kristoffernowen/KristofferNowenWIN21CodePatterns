using Fixxo.Core.Factories;
using Fixxo.Core.Models;

namespace Fixxo.MVC.Models.InputDto;

public static class CreateProductDtoExtensions
{
    public static ProductInCatalog ToModel(this CreateProductInputDto dto)
    {
        return ProductFactory.CreateProduct(dto.Category, dto.Name, dto.Price, dto.Rating, dto.ImgUrl);
    }
}