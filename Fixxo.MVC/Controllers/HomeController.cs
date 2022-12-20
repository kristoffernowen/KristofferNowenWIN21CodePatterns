using Microsoft.AspNetCore.Mvc;
using Fixxo.MVC.Factories;
using Fixxo.Core.Interface.Services;

namespace Fixxo.MVC.Controllers
{
    public class HomeController : Controller
    {

        // ansvarar för home view enligt srp, tror jag måste casta till ProductInCatalog här inne så kanske inte kan bryta ut den delen.

        // en massa hit och dit, men för att följa idén dto i frontend delen och att separera de från modellen fick jag krångla. Kanske inte bästa lsöningen,
        // men den som funkar än så länge

        private readonly IDisplayAllProductsService _displayAllProductsService;

        public HomeController(IDisplayAllProductsService displayAllProductsService)
        {
            _displayAllProductsService = displayAllProductsService;
        }


        public async Task<IActionResult> Index()
        {
            var iproductsList = await _displayAllProductsService.GetAsync();

            return iproductsList != null ? View(HomeIndexViewModelFactory.Create(iproductsList)) : View();
        }
    }
}
