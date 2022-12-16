using Fixxo.Core.Interface;
using Fixxo.MVC.Models.InputDto;
using Microsoft.AspNetCore.Mvc;

namespace Fixxo.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
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
            _productService.CreateAsync(dto.ToModel());

            return View();
        }
    }
}
