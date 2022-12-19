using Fixxo.Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Fixxo.MVC.Controllers
{
    public class DetailsProductsController : Controller
    {
        // srp : responsible for view of selected details product. Many different products, but always the same action action. So one controller

        private readonly IDisplayProductService _displayProductService;

        public DetailsProductsController(IDisplayProductService displayProductService)
        {
            _displayProductService = displayProductService;
        }

        [HttpGet]
        public async Task<IActionResult> Jacket(string id)
        {
            var guidId = new Guid(id);

            var jacket = await _displayProductService.GetJacketAsync(guidId);

            return View(jacket);
        }

        [HttpGet]
        public async Task<IActionResult> Shoes(string id)
        {

            var guidId = new Guid(id);

            var shoes = await _displayProductService.GetShoesAsync(guidId);

            return View(shoes);
        }
    }
}
