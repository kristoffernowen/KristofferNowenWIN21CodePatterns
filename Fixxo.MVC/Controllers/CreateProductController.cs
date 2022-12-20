using Fixxo.Core.Interface.Services;
using Fixxo.MVC.Models.InputDto;
using Microsoft.AspNetCore.Mvc;

namespace Fixxo.MVC.Controllers
{
    public class CreateProductController : Controller
    {
        // Mina produkter har en del, så create product får en egen controller , srp


        private readonly ICreateProductService _createProductService;


        public CreateProductController(ICreateProductService createProductService)
        {
            _createProductService = createProductService;
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductInputDto dto)
        {
            await _createProductService.CreateAsync(dto.ToModel());

            return View();
        }
    }
}
