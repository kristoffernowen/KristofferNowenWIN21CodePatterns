using System.ComponentModel.DataAnnotations;
using Fixxo.Data.Entities.ShoesEntities;
using Fixxo.Data.Interfaces.Entities;

namespace Fixxo.Data.Entities
{
    public class CatalogItemEntity : ICatalogItemEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Category { get; set; } = null!;
        public List<JacketEntity>? Jackets { get; set; }

        public List<ShoesEntity>? Shoes { get; set; }

        // public IProductInCatalog Product { get; set; }     Jag förstår inte hur jag ska mappa navigeringen
        // NoSql hade varit skönt, men med ef core fick jag samma problem. ren nosql i json object som document, men jag hinner nog inte fixa in det i den här uppgiften
    }
}
