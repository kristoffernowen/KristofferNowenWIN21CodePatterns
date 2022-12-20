using Microsoft.AspNetCore.Mvc;
using Fixxo.MVC.Factories;
using Fixxo.Core.Interface.Services;

namespace Fixxo.MVC.Controllers
{
    public class HomeController : Controller
    {

        /* ansvarar för home view enligt srp, tror jag måste casta till Product här inne så kanske inte kan bryta ut den delen.

         en massa hit och dit, men för att följa idén dto i frontend delen och att separera de från modellen fick jag krångla. Kanske inte bästa lsöningen,
         men den som funkar än så länge

         Jag ville egentligen bygga med hjälp av en IGetDto lista in som model i view, men jag tänkte fel och blev lurade av att jag satt arv på Shoes och Jacket, som 
        jag testade med först. Tror jag förstår hur jag behöver ändra men kanske inte hinner det. Så då får Boots och HighHeels också ärva så fungerar det 
        med GetProductOutputDto i , men men .... inte vad jag tänkt, jag ville bara visa att Shoes kan ärva Product...
        */


        private readonly IDisplayAllProductsService _displayAllProductsService;

        public HomeController(IDisplayAllProductsService displayAllProductsService)
        {
            _displayAllProductsService = displayAllProductsService;
        }


        public async Task<IActionResult> Index()
        {
            var iproductsList = await _displayAllProductsService.GetAsync();

            var returnList = HomeIndexViewModelFactory.Create(iproductsList);

            return View(returnList);

            // return iproductsList != null ? View(HomeIndexViewModelFactory.Create(iproductsList)) : View();
        }
    }
}
