using Fixxo.MVC.Models.OutputDto;
using Fixxo.MVC.Models.OutputDto.ShoesDto;

namespace Fixxo.MVC.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<GetJacketOutputDto> Jackets { get; set; } = new ();
        public List<GetShoesOutputDto> Shoes { get; set; } = new ();
        public List<GetBootsOutputDto> Boots { get; set; } = new();
        public List<GetHighHeelsOutputDto> HighHeels { get; set; } = new();

        
    }
}
