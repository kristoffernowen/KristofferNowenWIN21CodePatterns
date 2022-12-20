using Fixxo.Data.Interfaces.Entities;

namespace Fixxo.Data.Entities
{
    // Som exempel på lsp, jacket får ärva product. ProductInCatalog jacket = new JacketEntity(); ska fungera. Tycker bättre om interface men som exempel
    // är dubbelt med interfacet och arvklassen, men interface får vara kvar för att alla ska ha sina interface

    public class JacketEntity : ProductEntity, IJacketEntity
    {
        public string AvailableSizes { get; set; } = "S, M, L";
    }
}
