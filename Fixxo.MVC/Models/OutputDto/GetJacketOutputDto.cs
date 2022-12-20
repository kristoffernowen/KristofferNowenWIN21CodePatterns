using Fixxo.MVC.Interfaces.Models.OutputDto;

namespace Fixxo.MVC.Models.OutputDto
{
    public class GetJacketOutputDto : GetProductOutputDto, IGetJacketOutputDto
    {
        public string AvailableSizes { get; set; } = "S, M, L";
    }
}
