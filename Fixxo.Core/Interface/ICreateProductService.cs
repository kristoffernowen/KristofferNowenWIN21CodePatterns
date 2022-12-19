using Fixxo.Core.Models;

namespace Fixxo.Core.Interface;

public interface ICreateProductService
{
    public Task CreateAsync(Product model);
}