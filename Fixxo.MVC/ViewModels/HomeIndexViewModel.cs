﻿using Fixxo.Core.Models;
using Fixxo.MVC.Models.OutputDto;

namespace Fixxo.MVC.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Jacket> Jackets { get; set; } = new List<Jacket>();
        public List<Shoes> Shoes { get; set; } = new List<Shoes>();
        public List<IGetProductOutputDto> ProductsOutputDto { get; set; } = new ();
    }
}
