using Fixxo.MVC.Interfaces.Models.OutputDto;

namespace Fixxo.MVC.Models.OutputDto.ShoesDto
{
    public class GetShoesOutputDto : GetProductOutputDto, IGetShoesOutputDto
    {
        public int MaxSize { get; set; }
    }
}
