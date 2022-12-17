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
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }


        public async Task<IActionResult> Index()
        {
            

            var products = await _productService.GetAsync();

            var viewModel = new HomeIndexViewModel();

            foreach (var product in products.Where(product => product != null))
            {
                viewModel.Products.Add((product) as Product);
            }

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}