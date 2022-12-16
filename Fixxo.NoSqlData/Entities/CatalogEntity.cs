using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixxo.Core.Interface.Models;

namespace Fixxo.NoSqlData.Entities
{
    public class CatalogEntity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Category { get; set; }
        [NotMapped]
        public IProduct Product { get; set; }
    }
}
