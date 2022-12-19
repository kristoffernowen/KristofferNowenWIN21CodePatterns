using Fixxo.Core.Interface.Models;

namespace Fixxo.Core.Interface;

public interface IDisplayAllProductsService
{
    // lägger get all i ett eget interface så den inte försvinner med get enskilda, som på det här sättet blir många

    public Task<List<IProduct>> GetAsync();
}