using Fixxo.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Fixxo.Core.Interface;
using Fixxo.Core.Models;
using Fixxo.MVC.ViewModels;

namespace Fixxo.MVC.Controllers
{
    public class HomeController : Controller
    {

        // ansvarar för home view enligt srp


        private readonly IDisplayProductService _displayProductService;

        public HomeController(IDisplayProductService displayProductService)
        {
            _displayProductService = displayProductService;
        }


        public async Task<IActionResult> Index()
        {
            

            var products = await _displayProductService.GetAsync();

            var viewModel = new HomeIndexViewModel();

            foreach (var product in products.Where(product => product != null))
            {
                viewModel.Products.Add((product) as Product);
            }

            return View(viewModel);
        }
    }
}