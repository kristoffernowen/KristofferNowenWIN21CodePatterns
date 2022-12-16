using Fixxo.Core.Interface;
using Fixxo.MVC.Models.InputDto;
using Microsoft.AspNetCore.Mvc;

namespace Fixxo.MVC.Controllers
{
    public class ProductSqlController : Controller
    {
        private readonly IProductService _productService;

        public ProductSqlController(IProductService productService)
        {
            _productService = productService;
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
    }
}
