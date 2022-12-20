using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;
using Fixxo.MVC.Models.OutputDto;
using Fixxo.MVC.ViewModels;

namespace Fixxo.MVC.Factories
{
    public static class HomeIndexViewModelFactory
    {
        // Ska logiken vara här eller i en service i controllern? båda verkar sådär, men den används bara en gång så logiken får vara här så har jag städat undan den från controllern.
        // var outputDtos kunde kanske brytas ner, men det känns överdrivet utan nytta


        public static HomeIndexViewModel Create(List<IProductInCatalog> iProducts)
        {
            var outputDtos = iProducts.Select(iProduct => iProduct as ProductInCatalog).Select(product => product.ToDto()).ToList();

            var model = new HomeIndexViewModel();

            foreach (var dto in outputDtos)
            {
                model.ProductsOutputDto.Add(dto);
            }

            return model;
        }
    }
}
