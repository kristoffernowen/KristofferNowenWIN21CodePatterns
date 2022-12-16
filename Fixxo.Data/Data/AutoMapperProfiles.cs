using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fixxo.Core.Models;
using Fixxo.Data.Entities;

namespace Fixxo.Data.Data
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductEntity>().ReverseMap();
            CreateMap<Jacket, JacketEntity>().ReverseMap();
            CreateMap<Shoes, ShoesEntity>().ReverseMap();
        }
    }
}
