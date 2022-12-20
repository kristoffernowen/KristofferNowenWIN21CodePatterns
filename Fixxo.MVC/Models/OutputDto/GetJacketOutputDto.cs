using Fixxo.MVC.Interfaces;
using Fixxo.MVC.Interfaces.Models.OutputDto;

namespace Fixxo.MVC.Models.OutputDto
{
    // den får lsp ärva här liksom med models o entities för att spegla.

    public class GetJacketOutputDto : GetProductOutputDto, IGetJacketOutputDto, IGetDto
    {
        public string AvailableSizes { get; set; } = "S, M, L";
    }
}
