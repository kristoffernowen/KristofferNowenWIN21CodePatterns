using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixxo.Data.Entities
{
    public class ShoesEntity : ProductEntity
    {
        public CatalogItemEntity CatalogItem { get; set; }
        public Guid CatalogItemId { get; set; }
        public int MaxSize { get; set; } = 47;
    }
}
