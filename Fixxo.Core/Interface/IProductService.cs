using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixxo.Core.Models;

namespace Fixxo.Core.Interface
{
    public interface IProductService
    {
        public Task<List<Product>> GetAsync();
        public Task CreateAsync(Product model);
    }
    
    // public interface IProductServiceNoSql
    // {
    //     public Task<List<Product>> GetAsync();
    //     public Task CreateAsync(Product model);
    // }
}
