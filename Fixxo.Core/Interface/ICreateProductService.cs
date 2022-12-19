using Fixxo.Core.Models;

namespace Fixxo.Core.Interface;

public interface ICreateProductService
{
    // delar på Products, för det blir så mycket annars. Annars kunde crud ha varit en sak
    public Task CreateAsync(Product model);
}