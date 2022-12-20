using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;
using Fixxo.MVC.Models.OutputDto;

namespace Fixxo.MVC.Services
{
    public class GetProductsService
    {
        public List<ProductInCatalog> ToProduct(List<IProductInCatalog> iProducts)
        {
            var products = iProducts.Select(x => x as ProductInCatalog).ToList();
            return products!;
        }

        public List<GetProductOutputDto> ToDtoList(List<ProductInCatalog> products)
        {
            return products.Select(product => product.ToDto()).ToList();
        }
    }
}
