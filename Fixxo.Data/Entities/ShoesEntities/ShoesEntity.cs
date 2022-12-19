using Fixxo.Data.Interfaces.Entities.ShoeEntities;

namespace Fixxo.Data.Entities.ShoesEntities
{
    public class ShoesEntity : ProductEntity, IShoesEntity
    {
        public int MaxSize { get; set; } = 48;
        public int MinSize { get; set; } = 35;
    }
}
