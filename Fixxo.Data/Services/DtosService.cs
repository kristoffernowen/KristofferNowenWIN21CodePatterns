﻿using AutoMapper;
using Fixxo.Core.Interface.Models;
using Fixxo.Core.Models;
using Fixxo.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.Data.Services
{
    public class DtosService
    {
        private readonly SqlContext _context;
        private readonly IMapper _mapper;

        public DtosService(SqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<IProductInCatalog>> GetAsync()
        {
            var items = await _context.CatalogItems.ToListAsync();

            var products = new List<IProductInCatalog>();

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

            // var productsCasted = products.Select(product => (product) as ProductInCatalog).ToList(); kanske fungerar om jag ändrar return type, men sideffekter...

            return products;

        }
    }
}
