using Fixxo.Core.Interface;
using Fixxo.MVC.Models.InputDto;
using Microsoft.AspNetCore.Mvc;

namespace Fixxo.MVC.Controllers
{
    public class ProductSqlController : Controller
    {
        
        private readonly IProductService _productService;
        private readonly ICatalogItemService _catalogItemService;

        public ProductSqlController(IProductService productService, ICatalogItemService catalogItemService)
        {
            _productService = productService;
            _catalogItemService = catalogItemService;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductInputDto dto)
        {
            await _productService.CreateAsync(dto.ToModel());

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var product = await _catalogItemService.GetAsync(id);

            // inte nöjd över den här lösningen. Nosql hade nog varit bra men hinner inte bygga det, så.....

            return product.Category switch
            {
                "Jacket" => RedirectToAction("Jacket", "ProductSql", new {id}),
                "Shoes" => RedirectToAction("Shoes", "ProductSql", new {id}),
                _ => RedirectToAction("Index", "Home")
            };
        }

        [HttpGet]
        public async Task<IActionResult> Jacket(string id)
        {
            var _id = new Guid(id);

            var jacket = await _productService.GetJacketAsync(_id);

            return View(jacket);
        }

        [HttpGet]
        public async Task<IActionResult> Shoes(string id)
        {

            var _id = new Guid(id);

            var shoes = await _productService.GetShoesAsync(_id);

            return View(shoes);
        }
    }
}
