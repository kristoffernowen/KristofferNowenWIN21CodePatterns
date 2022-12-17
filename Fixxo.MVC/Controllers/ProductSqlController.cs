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

            switch (product.Category)
            {
                case "Jacket":
                    return RedirectToAction("Jacket", "ProductSql", new { id });
                case "Shoes":
                    return RedirectToAction("Shoes", "ProductSql", new { id });
            }

            return RedirectToAction("Index", "Home");
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
