using Fixxo.MVC.Interfaces.Models.OutputDto;

namespace Fixxo.MVC.Models.OutputDto.ShoesDto
{
    public class GetShoesOutputDto : GetProductOutputDto, IGetShoesOutputDto
    {
        public int MaxSize { get; set; } = 46;
        public int MinSize { get; set; } = 35;
    }
}
