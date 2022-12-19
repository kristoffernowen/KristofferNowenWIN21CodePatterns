using Fixxo.Core.Models;

namespace Fixxo.Core.Interface.Services
{
    public interface ICatalogItemService
    {
        // srp, isp - jag delade products på create och display för den svämmade över lite. Annars tycker jag det är generellt vettigt att saäga att crud är en grej
        public Task<CatalogItem> GetAsync(Guid id);
        public Task<Guid> CreateAsync(string category);
    }
}
