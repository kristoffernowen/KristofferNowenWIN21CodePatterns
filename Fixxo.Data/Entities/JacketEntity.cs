using Fixxo.Data.Interfaces.Entities;

namespace Fixxo.Data.Entities
{
    public class JacketEntity : ProductEntity, IJacketEntity
    {
        public string AvailableSizes { get; set; } = "S, M, L";
    }
}
