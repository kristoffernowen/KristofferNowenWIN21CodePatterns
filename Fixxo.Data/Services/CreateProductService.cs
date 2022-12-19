using Fixxo.Core.Interface.Services;
using Fixxo.Core.Models;
using Fixxo.Data.Data;
using Fixxo.Data.Factories;

namespace Fixxo.Data.Services;

public class CreateProductService : ICreateProductService
{
    private readonly SqlContext _context;
    private readonly ICatalogItemService _catalogItemService;

    public CreateProductService(SqlContext context, ICatalogItemService catalogItemService)
    {
        _context = context;
        _catalogItemService = catalogItemService;
    }

    public async Task CreateAsync(Product model)
    {
        // srp - det här skapar bara en sak, fast olika klasser, tycker de kan vara i en service - ett syfte. 
        // isp - interfacet är bara hit
        // dip - använder factory för att få bort initieringen


        switch (model.Category)
        {
            case "Jacket":
                var jacketId = await _catalogItemService.CreateAsync(model.Category);

                var jacketEntity = JacketEntityFactory.Create(model.Category, model.Name, model.Rating, model.Price, model.ImgUrl);
                jacketEntity.CatalogItemId = jacketId;

                _context.Jackets.Add(jacketEntity);
                await _context.SaveChangesAsync();
                break;

            case "Shoes":
                var shoesId = await _catalogItemService.CreateAsync(model.Category);
                var shoesEntity = ShoesEntityFactory.Create(model.Category, model.Name, model.Rating, model.Price,
                    model.ImgUrl);
                shoesEntity.CatalogItemId = shoesId;

                _context.Shoes.Add(shoesEntity);
                await _context.SaveChangesAsync();
                break;
        }

    }
}