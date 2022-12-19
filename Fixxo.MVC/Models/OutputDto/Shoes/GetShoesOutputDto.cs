using Fixxo.MVC.Interfaces.Models.OutputDto;

namespace Fixxo.MVC.Models.OutputDto.Shoes
{
    public class GetShoesOutputDto : GetProductOutputDto, IGetShoesOutputDto
    {
        public int MaxSize { get; set; }
    }
}
