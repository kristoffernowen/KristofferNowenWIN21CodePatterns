using Fixxo.Core.Factories;
using Fixxo.Core.Models;

namespace Fixxo.MVC.Models.InputDto;

public static class CreateProductDtoExtensions
{
    public static Product ToModel(this CreateProductInputDto dto)
    {
        return ProductFactory.CreateProduct(dto.Category, dto.Name, dto.Price, dto.Rating, (true) ? dto.ImgUrl : "https://images.pexels.com/photos/235621/pexels-photo-235621.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1");
    }
}