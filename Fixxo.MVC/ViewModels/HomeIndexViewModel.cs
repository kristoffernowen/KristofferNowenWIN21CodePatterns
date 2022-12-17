using Fixxo.Core.Models;

namespace Fixxo.MVC.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Jacket> Jackets { get; set; } = new List<Jacket>();
        public List<Shoes> Shoes { get; set; } = new List<Shoes>();
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
