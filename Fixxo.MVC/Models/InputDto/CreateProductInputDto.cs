using Fixxo.MVC.Interfaces.Models.InputDto;

namespace Fixxo.MVC.Models.InputDto
{
    public class CreateProductInputDto : ICreateProductInputDto
    {
        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; } = null!;
    }
}
