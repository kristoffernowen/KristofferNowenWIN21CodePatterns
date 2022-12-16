﻿using Fixxo.Core.Interface.Models;

namespace Fixxo.MVC.Models.OutputDto
{
    public class GetProductOutputDto : IProduct
    {
        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
    }
}
