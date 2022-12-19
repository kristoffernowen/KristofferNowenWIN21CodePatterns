using System.Diagnostics;
using AutoMapper;
using Fixxo.Core.Factories;
using Fixxo.Core.Interface;
using Fixxo.Core.Models;
using Fixxo.Data.Data;
using Fixxo.Data.Entities;

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
            Debug.Assert(_context.CatalogItems != null, "_context.CatalogItems != null");
            var item = await _context.CatalogItems.FindAsync(id);

            return _mapper.Map<CatalogItem>(item);
        }

        public async Task<Guid> CreateAsync(string category)
        {
            // använder generic factory för det är så enkelt att peta in category manuellt

            var catalogItem
                = GenericFactory.Create<CatalogItemEntity>();
            catalogItem.Category = category;
            var entity = _context.CatalogItems.Add(catalogItem);
            await _context.SaveChangesAsync();

            return entity.Entity.Id;
        }
    }
}
