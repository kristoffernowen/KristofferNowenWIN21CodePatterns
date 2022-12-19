using Fixxo.Core.Interface.Services;
using Fixxo.Core.Models;
using Fixxo.MVC.Models.OutputDto;
using Fixxo.MVC.Models.OutputDto.ShoesDto;
using Microsoft.AspNetCore.Mvc;

namespace Fixxo.MVC.Controllers
{
    public class DetailsProductsController : Controller
    {
        // srp : responsible for view of selected details product. Many different products, but always the same action action. So one controller  english yeah baby!!!!!!!!!!

        private readonly IDisplayProductService _displayProductService;

        public DetailsProductsController(IDisplayProductService displayProductService)
        {
            _displayProductService = displayProductService;
        }

        [HttpGet]
        public async Task<IActionResult> Jacket(string id)
        {
            var jacket = await _displayProductService.GetJacketAsync(new Guid(id));

            return View(jacket.ToDto());
        }

        [HttpGet]
        public async Task<IActionResult> Shoes(string id)
        {
            var shoes = await _displayProductService.GetShoesAsync(new Guid(id));

            return View(shoes.ToDto());
        }

        [HttpGet]
        public async Task<IActionResult> Boots(string id)
        {
            var boots = await _displayProductService.GetBootsAsync(new Guid(id));
            
            // Kolla vad som hände här med arv och interface...

            return View(boots.ToDto());
        }

        [HttpGet]
        public async Task<IActionResult> HighHeels(string id)
        {
            var highHeels = await _displayProductService.GetHighHeelsAsync(new Guid(id));

            return View(highHeels.ToDto());
        }
    }
}
