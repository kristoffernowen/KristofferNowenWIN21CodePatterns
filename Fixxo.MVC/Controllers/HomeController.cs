using Fixxo.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO.Compression;
using Fixxo.Core.Interface;
using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;
using Fixxo.MVC.Models.OutputDto;
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

        // public async Task<IActionResult> Index()
        // {
        //     var products = await _productService.GetAsync();
        //
        //     var _products = products.Select(model => model.ToDto()).ToList();
        //
        //     List<IProduct> iproducts = new List<IProduct>();
        //
        //     foreach (var product in _products)
        //     {
        //         iproducts.Add(product);
        //     }
        //
        //     return View( products.Select(model => model.ToDto()).ToList());
        // }

        public async Task<IActionResult> Index()
        {
            // var products = await _productService.GetCatalogAsync();
            //
            // // var _products = products.Select(model => model.ToDto()).ToList();
            //
            // List<IProduct> iproducts = new List<IProduct>();
            //
            // foreach (var product in products)
            // {
            //     var dto = new GetProductOutputDto
            //     {
            //         Category = product.
            //     }
            //     iproducts.Add(product);
            // }
            //
            //
            //
            // return View(products.Select(model => model.ToDto()).ToList());

            var products = await _productService.GetAsync();

            var viewModel = new HomeIndexViewModel();

            foreach (var product in products)
            {
                if (product is Jacket)
                {
                    var jacket = (product) as Jacket;
                    viewModel.Jackets.Add(jacket);
                }

                if (product is Shoes)
                {
                    viewModel.Shoes.Add((product) as Shoes);
                }
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