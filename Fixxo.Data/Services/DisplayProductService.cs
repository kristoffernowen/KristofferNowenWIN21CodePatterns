using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using Fixxo.Core.Factories;
using Fixxo.Core.Interface;
using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;
using Fixxo.Data.Data;
using Fixxo.Data.Entities;
using Fixxo.Data.Factories;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.Data.Services
{
    public class DisplayProductService : IDisplayProductService
    {
        private readonly SqlContext _context;
        private readonly IMapper _mapper;

        public DisplayProductService(SqlContext context, IMapper mapper)
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
                    default:
                        break;
                }
            }

            return products;

        }

       

        public async Task<Jacket> GetJacketAsync(Guid id)
        {
            var jacket = await _context.Jackets.FirstOrDefaultAsync(x => x.CatalogItemId.Equals(id));
            return _mapper.Map<Jacket>(jacket);
        }

        public async Task<Shoes> GetShoesAsync(Guid id)
        {
            var shoes = await _context.Shoes.FirstOrDefaultAsync(s => s.CatalogItemId.Equals(id));
            return _mapper.Map<Shoes>(shoes);
        }
        
    }
}
