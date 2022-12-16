using AutoMapper;
using Fixxo.Core.Interface;
using Fixxo.Core.Models;
using Fixxo.Data.Data;
using Fixxo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.Data.Services
{
    public class ProductService : IProductService
    {
        private readonly SqlContext _context;
        private readonly IMapper _mapper;

        public ProductService(SqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<Product>> GetAsync()
        {
            return await _context.Products.Select(entity => _mapper.Map<Product>(entity)).ToListAsync();
        }

        public async Task CreateAsync(Product model)
        {
            _context.Products.Add(_mapper.Map<ProductEntity>(model));
            await _context.SaveChangesAsync();
        }
    }
}
