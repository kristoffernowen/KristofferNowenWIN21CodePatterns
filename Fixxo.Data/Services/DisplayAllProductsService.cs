using AutoMapper;
using Fixxo.Core.Interface;
using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;
using Fixxo.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.Data.Services
{
    public class DisplayAllProductsService : IDisplayAllProductsService
    {
        private readonly SqlContext _context;
        private readonly IMapper _mapper;

        public DisplayAllProductsService(SqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<IProduct>> GetAsync()
        {
            var items = await _context.CatalogItems.ToListAsync();

            var products = new List<IProduct>();

            foreach (var item in items)
            {
                switch (item.Category)
                {
                    case "Jacket":
                        var jacket = await _context.Jackets.FirstOrDefaultAsync(j => j.CatalogItemId == item.Id);
                        products.Add(_mapper.Map<Jacket>(jacket));
                        break;
                    case "Shoes":
                        var shoes = await _context.Shoes.FirstOrDefaultAsync(s => s.CatalogItemId == item.Id);
                        products.Add(_mapper.Map<Shoes>(shoes));
                        break;
                }
            }

            // var productsCasted = products.Select(product => (product) as Product).ToList(); kanske fungerar om jag ändrar return type, men sideffekter...

            return products;

        }

        public List<Product> ToProduct(List<IProduct> iProducts)
        {
            var products = iProducts.Select(x => x as Product).ToList();
            return products!;
        }
    }
}
