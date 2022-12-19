using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;

namespace Fixxo.Core.Interface
{
    public interface IDisplayProductService
    {
        // ansvarar för att hämta produkter - en sak

        public Task<List<IProduct>> GetAsync();
        
        public Task<Shoes> GetShoesAsync(Guid id);
        public Task<Jacket> GetJacketAsync(Guid id);

    }
}
