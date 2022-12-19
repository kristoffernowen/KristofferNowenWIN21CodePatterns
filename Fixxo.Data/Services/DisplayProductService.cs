using AutoMapper;
using Fixxo.Core.Interface;
using Fixxo.Core.Models;
using Fixxo.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.Data.Services
{
    //Ansvarig för att hämta en produkt till display = en grej. Lägger listan-get all för sig för de kanske ska användas lite olika

    public class DisplayProductService : IDisplayProductService
    {
        private readonly SqlContext _context;
        private readonly IMapper _mapper;

        public DisplayProductService(SqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
