using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;

namespace Fixxo.Core.Interface
{
    public interface IProductService
    {
        public Task<List<IProduct>> GetAsync();
        public Task CreateAsync(Product model);

        // public Task<List<Catalog>> GetCatalogAsync();
        public Task<Shoes> GetShoesAsync(Guid id);
        public Task<Jacket> GetJacketAsync(Guid id);

    }
}
