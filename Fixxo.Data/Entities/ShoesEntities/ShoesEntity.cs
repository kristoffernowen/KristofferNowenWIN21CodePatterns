using Fixxo.Data.Interfaces.Entities.ShoeEntities;

namespace Fixxo.Data.Entities.ShoesEntities
{
    // Som exempel på lsp, jacket får ärva product. ProductInCatalog jacket = new JacketEntity(); ska fungera. Tycker bättre om interface men som exempel
    public class ShoesEntity : ProductEntity, IShoesEntity
    {
        public int MaxSize { get; set; } = 48;
        public int MinSize { get; set; } = 35;
    }
}
