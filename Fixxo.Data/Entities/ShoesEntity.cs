using Fixxo.Data.Interfaces.Entities.ShoeEntities;

namespace Fixxo.Data.Entities
{
    public class ShoesEntity : ProductEntity, IShoesEntity
    {
        public int MaxSize { get; set; }
        public int MinSize { get; set; }
    }
}
