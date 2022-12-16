using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fixxo.Core.Interface;
using Fixxo.Core.Models;
using Fixxo.Data.Data;
using Fixxo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.NoSqlData.Services
{
    public class ProductService : IProductService
    {
        private readonly NoSqlContext _context;
        private readonly IMapper _mapper;

        public ProductService(NoSqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<Product>> GetAsync()
        {
            var products = await _context.Products.ToListAsync();

            if (products != null)
                return products.Select(entity => entity.ToModel()).ToList();

            return null;
        }

        public async Task CreateAsync(Product model)
        {
            _context.Products.Add(_mapper.Map<ProductEntity>(model));

            await _context.SaveChangesAsync();
        }
    }
}
