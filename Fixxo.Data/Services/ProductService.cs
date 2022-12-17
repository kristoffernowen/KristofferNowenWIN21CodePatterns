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
    public class ProductService : IProductService
    {
        private readonly SqlContext _context;
        private readonly IMapper _mapper;

        public ProductService(SqlContext context, IMapper mapper)
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



            // return null;
            // return await _context.Products.Select(entity => _mapper.Map<Product>(entity)).ToListAsync();
        }

        public async Task CreateAsync(Product model)
        {
            switch (model.Category)
            {
                case "Jacket":
                    var catalogJacket
                        = GenericFactory.Create<CatalogItemEntity>();
                    catalogJacket.Category = model.Category;
                    var catalogJacketEntity = _context.CatalogItems.Add(catalogJacket);
                    var jacketEntity = JacketEntityFactory.Create(model.Category, model.Name, model.Rating, model.Price);
                    jacketEntity.CatalogItemId = catalogJacketEntity.Entity.Id;
                    _context.Jackets.Add(jacketEntity);
                    await _context.SaveChangesAsync();
                    break;

                case "Shoes": 
                    var catalogShoes = GenericFactory.Create<CatalogItemEntity>();
                    catalogShoes.Category = model.Category;
                    var catalogShoesEntity = _context.CatalogItems.Add(catalogShoes);
                    var shoesEntity = ShoesEntityFactory.Create(model.Category, model.Name, model.Rating, model.Price);
                    shoesEntity.CatalogItemId = catalogShoesEntity.Entity.Id;
                    _context.Shoes.Add(shoesEntity);
                    await _context.SaveChangesAsync();
                    break;

                default: break;
            }

            // _context.Products.Add(_mapper.Map<ProductEntity>(model));
            // await _context.SaveChangesAsync();
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
