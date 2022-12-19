using Fixxo.Data.Entities;

namespace Fixxo.Data.Interfaces.Entities;

public interface ICatalogItemEntity
{
    Guid Id { get; set; }
    string Category { get; set; }
    List<JacketEntity>? Jackets { get; set; }
    List<ShoesEntity>? Shoes { get; set; }
}