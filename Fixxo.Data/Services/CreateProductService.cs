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

        // inte så dry men jag har inte lärt mig dynamiskt och generiskt så bra...

        // måste hämta id catalogitemid här för det går inte i static fabriken, sen är det bara context.add och save async kvar som jag inte bryter ut

        switch (model.Category)
        {
            case "Jacket":

                _context.Jackets!.Add(JacketEntityFactory.Create
                (model.Category, model.Name, model.Rating, model.Price, model.ImgUrl,
                    await _catalogItemService.CreateAsync(model.Category)));

                await _context.SaveChangesAsync();
                break;

            case "Shoes":

                _context.Shoes!.Add(ShoesEntityFactory.Create
                (model.Category, model.Name, model.Rating, model.Price,
                    model.ImgUrl, await _catalogItemService.CreateAsync(model.Category)));

                await _context.SaveChangesAsync();
                break;

            case "Boots":
                
                _context.Boots.Add(BootsEntityFactory.Create(model.Category, model.Name, model.Rating, model.Price,
                    model.ImgUrl, await _catalogItemService.CreateAsync(model.Category)));

                await _context.SaveChangesAsync();
                break;

            case "High heels":
                
                
                _context.HighHeels.Add(HighHeelsEntityFactory.Create(model.Category, model.Name, model.Rating,
                    model.Price, model.ImgUrl, await _catalogItemService.CreateAsync(model.Category)));

                await _context.SaveChangesAsync();
                break;
        }

    }
}