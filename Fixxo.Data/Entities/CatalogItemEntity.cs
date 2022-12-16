using Fixxo.Core.Interface.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
