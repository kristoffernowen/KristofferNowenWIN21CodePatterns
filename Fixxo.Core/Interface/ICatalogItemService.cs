using Fixxo.Core.Models;

namespace Fixxo.Core.Interface
{
    public interface ICatalogItemService
    {
        public Task<CatalogItem> GetAsync(Guid id);
    }
}
