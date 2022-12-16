using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixxo.Core.Interface.Models;

namespace Fixxo.Core.Models
{
    public class Catalog
    {
        public string Category { get; set; }
        public IProduct Product { get; set; }
    }
}
