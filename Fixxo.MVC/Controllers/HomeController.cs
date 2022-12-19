using Fixxo.Core.Factories;
using Microsoft.AspNetCore.Mvc;
using Fixxo.Core.Interface;
using Fixxo.Core.Models;
using Fixxo.MVC.Factories;
using Fixxo.MVC.Models.OutputDto;
using Fixxo.MVC.Services;
using Fixxo.MVC.ViewModels;

namespace Fixxo.MVC.Controllers
{
    public class HomeController : Controller
    {

        // ansvarar för home view enligt srp, tror jag måste casta till Product här inne så kanske inte kan bryta ut den delen.

        // en massa hit och dit, men för att följa idén dto i frontend delen och att separera de från modellen fick jag krångla. Kanske inte bästa lsöningen,
        // men den som funkar än så länge

        private readonly IDisplayAllProductsService _displayAllProductsService;
        private readonly GetProductsService _getProductsService;

        public HomeController(IDisplayAllProductsService displayAllProductsService, GetProductsService getProductsService)
        {
            _displayAllProductsService = displayAllProductsService;
            _getProductsService = getProductsService;
        }


        public async Task<IActionResult> Index()
        {
            var iproductsList = await _displayAllProductsService.GetAsync();

            

            return View(HomeIndexViewModelFactory.Create(iproductsList));

            // borde jag skapa en homeindexviewfactory och ha det här i konstruktorn kanske, skicka in iproductslist som parameter. Ja

            // var viewModel = GenericFactory.Create<HomeIndexViewModel>(); 
            //
            // var productList = _getProductsService.ToProduct(iproductsList);
            // var dtoList = _getProductsService.ToDtoList(productList);
            //
            // foreach (var dto in dtoList)
            // {
            //     viewModel.ProductsOutputDto.Add(dto);
            // }
        }
    }
}



// var productList = iproductsList.Select(x => x as Product).ToList().Select(y => y.ToDto()).ToList();

// fick lite svårt att bestämma mig för vad som är bättre. Den över här är mer distinkt tycker jag. Den under lyfter ut lite funktion till en service.
// dto behandlingen måste ske här eftersom service 

// var productList = _displayAllProductsService.ToProduct(iproductsList);

// var dtoList = productList.Select(y => y.ToDto()).ToList();

// foreach (var product in products.Where(product => product != null))
// {
//     viewModel.ProductsOutputDto.Add(product as Product);
//
// }