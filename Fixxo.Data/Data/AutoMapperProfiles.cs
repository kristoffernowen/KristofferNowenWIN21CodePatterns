using AutoMapper;
using Fixxo.Core.Models;
using Fixxo.Data.Entities;
using Fixxo.Data.Entities.ShoesEntities;

namespace Fixxo.Data.Data
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductEntity>().ReverseMap();
            CreateMap<Jacket, JacketEntity>().ReverseMap();
            CreateMap<Shoes, ShoesEntity>().ReverseMap();
            CreateMap<Boots, BootsEntity>().ReverseMap();
            CreateMap<HighHeels, HighHeelsEntity>().ReverseMap();
            CreateMap<CatalogItem, CatalogItemEntity>().ReverseMap();
        }
    }
}
