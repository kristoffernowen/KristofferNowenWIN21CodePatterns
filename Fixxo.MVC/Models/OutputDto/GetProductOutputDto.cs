using Fixxo.MVC.Interfaces;
using Fixxo.MVC.Interfaces.Models.OutputDto;

namespace Fixxo.MVC.Models.OutputDto
{
    public class GetProductOutputDto : IGetDto, IGetProductOutputDto
    {
        public string Id { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public Guid CatalogItemId { get; set; }

        public string ImgUrl { get; set; } = null!;
    }
}
