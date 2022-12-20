using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;
using Fixxo.MVC.Models.OutputDto;
using Fixxo.MVC.Models.OutputDto.ShoesDto;
using Fixxo.MVC.ViewModels;

namespace Fixxo.MVC.Factories
{
    public static class HomeIndexViewModelFactory
    {
        // Ska logiken vara här eller i en service i controllern? båda verkar sådär, men den används bara en gång så logiken får vara här så har jag städat undan den från controllern.
        // var outputDtos kunde kanske brytas ner, men det känns överdrivet utan nytta


        // 

        public static HomeIndexViewModel Create(List<IProductInCatalog> iProductInCatalog)
        {
            var outputDtos = iProductInCatalog.Select(inCatalog => inCatalog as Product).Select(product => product.ToDto()).ToList();
            
            var model = new HomeIndexViewModel();
            
            foreach (var dto in outputDtos)
            {
                model.ProductsOutputDto.Add(dto);
            }
            
            return model;          //  This worked when Boots and HighHeels models inherited Product



            // var viewModel = new HomeIndexViewModel();
            // // var modelList = new List<IProductInCatalog>();
            //
            // foreach (var productInCatalog in iProductInCatalog)
            // {
            //     if (productInCatalog is Jacket jacket)
            //     {
            //         jacket = (jacket as Jacket);
            //         viewModel.GetDtos.Add(jacket.ToDto());
            //     }
            //
            //
            //     if (productInCatalog is Shoes shoes)
            //     {
            //         shoes = (shoes as Shoes);
            //         viewModel.GetDtos.Add(shoes.ToDto());
            //     }
            //
            //     if (productInCatalog is Boots boots)
            //     {
            //         boots = (boots as Boots);
            //         viewModel.GetDtos.Add(boots.ToDto());
            //     }
            //
            //     if (productInCatalog is HighHeels heels)
            //     {
            //         heels = (heels as HighHeels);
            //         viewModel.GetDtos.Add(heels.ToDto());
            //     }
            // }
            //
            //
            // return viewModel;

        }
    }
}
