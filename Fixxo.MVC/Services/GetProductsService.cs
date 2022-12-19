using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;
using Fixxo.MVC.Models.OutputDto;

namespace Fixxo.MVC.Services
{
    public class GetProductsService
    {
        public List<Product> ToProduct(List<IProduct> iProducts)
        {
            var products = iProducts.Select(x => x as Product).ToList();
            return products!;
        }

        public List<GetProductOutputDto> ToDtoList(List<Product> products)
        {
            return products.Select(product => product.ToDto()).ToList();
        }
    }
}
