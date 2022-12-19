using Fixxo.Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Fixxo.MVC.Controllers
{
    public class DetailsProductsController : Controller
    {
        // srp : responsible for view of details product. Many different products, but one action

        private readonly IDisplayProductService _displayProductService;

        public DetailsProductsController(IDisplayProductService displayProductService)
        {
            _displayProductService = displayProductService;
        }

        [HttpGet]
        public async Task<IActionResult> Jacket(string id)
        {
            var _id = new Guid(id);

            var jacket = await _displayProductService.GetJacketAsync(_id);

            return View(jacket);
        }

        [HttpGet]
        public async Task<IActionResult> Shoes(string id)
        {

            var _id = new Guid(id);

            var shoes = await _displayProductService.GetShoesAsync(_id);

            return View(shoes);
        }
    }
}
