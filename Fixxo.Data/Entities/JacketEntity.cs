using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixxo.Data.Entities
{
    public class JacketEntity : ProductEntity
    {
        public CatalogItemEntity CatalogItem { get; set; }
        public Guid CatalogItemId { get; set; }
        public string AvailableSizes { get; set; } = "S, M, L";
    }
}
