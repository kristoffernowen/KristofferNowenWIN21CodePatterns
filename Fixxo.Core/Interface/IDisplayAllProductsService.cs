using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;

namespace Fixxo.Core.Interface;

public interface IDisplayAllProductsService
{
    // lägger get all i ett eget interface så den inte försvinner med get enskilda, som på det här sättet blir många

    public Task<List<IProduct>> GetAsync();

    // denna har bara existens berättigande så länge get ser ut så här, så därför tycker jag de kan vara tillsammans, de måste ändras tillsammans
    public List<Product> ToProduct(List<IProduct> iProducts);
}