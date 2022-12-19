using Fixxo.Core.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace Fixxo.MVC.Controllers
{
    public class DetailsSwitchController : Controller
    {

        // srp sköter switch för vilken details produkt. Den här switch kan potentiellt bli väldigt lång, så egen controller

        private readonly ICatalogItemService _catalogItemService;

        public DetailsSwitchController(ICatalogItemService catalogItemService)
        {
            _catalogItemService = catalogItemService;
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var product = await _catalogItemService.GetAsync(id);

            // inte nöjd över den här lösningen. Nosql utan ef core hade nog varit bra men hinner inte läsa på och bygga det, så.....

            return product.Category switch
            {
                "Jacket" => RedirectToAction("Jacket", "DetailsProducts", new { id }),
                "Shoes" => RedirectToAction("Shoes", "DetailsProducts", new { id }),
                "Boots" => RedirectToAction("Boots", "DetailsProducts", new { id }),
                "High heels" => RedirectToAction("HighHeels", "DetailsProducts", new { id }),
                _ => RedirectToAction("Index", "Home")
            };
        }
    }
}
