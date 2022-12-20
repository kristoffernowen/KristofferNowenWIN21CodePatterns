using Fixxo.MVC.Interfaces;
using Fixxo.MVC.Interfaces.Models.OutputDto;

namespace Fixxo.MVC.Models.OutputDto.ShoesDto
{
    // den får lsp ärva här liksom med models o entities för att spegla.
    public class GetShoesOutputDto : GetProductOutputDto, IGetShoesOutputDto, IGetDto
    {
        public int MaxSize { get; set; } = 46;
        public int MinSize { get; set; } = 35;
    }
}
