using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;
using Fixxo.MVC.Models.OutputDto;
using Fixxo.MVC.ViewModels;

namespace Fixxo.MVC.Factories
{
    public static class HomeIndexViewModelFactory
    {
        // Ska logiken vara här eller i controllern? båda verkar sådär, men den används bara en gång så logiken får vara här så har jag städat undan den från controllern.
        public static HomeIndexViewModel Create(List<IProduct> iProducts)
        {
            var outputDtos = iProducts.Select(x => x as Product).ToList().Select(product => product.ToDto()).ToList();

            var model = new HomeIndexViewModel();

            foreach (var dto in outputDtos)
            {
                model.ProductsOutputDto.Add(dto);
            }

            return model;
        }
    }
}
