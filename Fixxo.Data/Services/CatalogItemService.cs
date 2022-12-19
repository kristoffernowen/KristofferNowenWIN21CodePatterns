using AutoMapper;
using Fixxo.Core.Factories;
using Fixxo.Core.Interface;
using Fixxo.Core.Models;
using Fixxo.Data.Data;
using Fixxo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.Data.Services
{
    internal class CatalogItemService : ICatalogItemService
    {
        private readonly SqlContext _context;
        private readonly IMapper _mapper;

        public CatalogItemService(SqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<CatalogItem> GetAsync(Guid id)
        {
            var item = await _context.CatalogItems.FindAsync(id);

            return _mapper.Map<CatalogItem>(item);
        }

        public async Task<Guid> CreateAsync(string category)
        {
            var catalogItem
                = GenericFactory.Create<CatalogItemEntity>();
            catalogItem.Category = category;
            var entity = _context.CatalogItems.Add(catalogItem);
            await _context.SaveChangesAsync();

            return entity.Entity.Id;
        }
    }
}
