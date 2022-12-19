﻿using System.ComponentModel.DataAnnotations;

namespace Fixxo.Data.Entities
{
    public class ProductEntity
    {
        [Key]
        public Guid Id { get; set; }

        public CatalogItemEntity CatalogItem { get; set; } = null!;
        
        public Guid CatalogItemId { get; set; }
        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; } = null!;
    }
}
