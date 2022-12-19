using AutoMapper;
using Fixxo.Core.Factories;
using Fixxo.Core.Interface.Models;
using Fixxo.Core.Interface.Services;
using Fixxo.Core.Models;
using Fixxo.Data.Entities;
using Fixxo.NoSqlData.Data;
using Fixxo.NoSqlData.Entities;
using Fixxo.NoSqlData.Factories;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.NoSqlData.Services
{
    public class ProductService : IProductServiceNoSql
    {
        private readonly NoSqlContext _context;
        private readonly IMapper _mapper;

        public ProductService(NoSqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // public async Task<List<Product>> GetAsync()
        // {
        //     var products = await _context.Products.ToListAsync();
        //
        //     if (products != null)
        //         return products.Select(entity => entity.ToModel()).ToList();
        //
        //     return null;
        // }

        public async Task<List<IProduct>> GetAsync()
        {

            // en tom lista behöver ingen factory

            // var jackets = await _context.Jackets.Select(j=> j.ToModel()).ToListAsync();
            // var shoes = await _context.Shoes.Select(e => e.ToModel()).ToListAsync();

            List<IProduct> products = new List<IProduct>();

            // foreach (var jacket in jackets)
            // {
            //     products.Add(jacket);
            // }
            //
            // foreach (var shoe in shoes)
            // {
            //     products.Add(shoe);
            // }
            //
            //
            // if (products != null)
            //     return products;

            return products;
        }



        public async Task CreateAsync(Product model)
        {
            // switch (model.Category)    funkar på nån nivå
            // {
            //     case "Jacket":
            //         var jacketEntity = _context.Jackets.Add(_mapper.Map<JacketEntity>(model));
            //         _context.CatalogEntities.Add(new CatalogEntity {Category = model.Category, Id = jacketEntity.Entity.Id});
            //         await _context.SaveChangesAsync();
            //         break;
            //
            //     case "Shoes":
            //         var shoesEntity = _context.Shoes.Add(_mapper.Map<ShoesEntity>(model));
            //         _context.CatalogEntities.Add(new CatalogEntity { Category = model.Category, Id = shoesEntity.Entity.Id });
            //         await _context.SaveChangesAsync();
            //         break;
            //
            //     default:
            //         break;
            // }

            


            // _context.Products.Add(_mapper.Map<ProductEntity>(model));


            /* Fungerar inte ner i databasen
             *
             * Kändes smidigt att implementera DIP med generic på catalogentity men specifik fabrik på de andra. Lite kaka på kaka när jag jobbat med
             * extensionmetoder, tror jag ändå bara initierar på ett ställe, men jag la in fabrikerna för uppgiftens skull
             *
             */

            switch (model.Category)
            {
                case "Jacket":
                {
                    var jacket = JacketEntityFactory.Create(model.Category, model.Name, model.Rating, model.Price, "S");
                    var entity = GenericFactory.Create<CatalogEntity>();
                    entity.Category = model.Category;
                    entity.Product = jacket;
                    
                    // var e =_context.CatalogEntities.Add(entity);
                    // jacket.JacketId = e.Entity.Id;
                    // _context.Jackets.Add(jacket);

                    await _context.SaveChangesAsync();
                    break;
                }
                case "Shoes":
                {
                    var shoes = ShoesFactory.Create(model.Category, model.Name, model.Rating, model.Price);
                    var entity = GenericFactory.Create<CatalogEntity>();
                    entity.Category = model.Category;
                    entity.Product = shoes;

                    _context.CatalogEntities.Add(entity);
                    await _context.SaveChangesAsync();
                    break;
                }
            }
        }

        // public async Task<List<CatalogEntity>> GetCatalogAsync()
        // {
        //
        //     var catalog = await _context.CatalogEntities.ToListAsync();
        //
        //     List<IProduct> products = new List<IProduct>();
        //
        //     foreach (var catalogEntity in catalog)
        //     {
        //         if (catalogEntity.Category == "Jacket")
        //         {
        //             var j = await _context.Jackets.FirstOrDefaultAsync(x => x.Id == catalogEntity.Id);
        //             products.Add(j.ToModel());
        //         }
        //         else if (catalogEntity.Category == "Shoes")
        //         {
        //             var s = await _context.Shoes.FirstOrDefaultAsync(s => s.Id == catalogEntity.Id);
        //             products.Add(s.ToModel());
        //         }
        //     }
        //
        //     
        //
        //     return products;
        // }
    }
}

