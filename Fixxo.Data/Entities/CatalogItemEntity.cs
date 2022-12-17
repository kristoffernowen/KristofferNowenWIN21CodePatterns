using System.ComponentModel.DataAnnotations;

namespace Fixxo.Data.Entities
{
    public class CatalogItemEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Category { get; set; }
        public List<JacketEntity> Jackets { get; set; }

        public List<ShoesEntity> Shoes { get; set; }

        // public IProduct Product { get; set; }
    }
}
