using Fixxo.Core.Interface.Models;

namespace Fixxo.Core.Models
{


    /* OCP    ProductInCatalog implementerar IProductInCatalog så alla products kan vara i en lista
     *          Jag förlänger ProductInCatalog med arv in i t ex Shoes och Jacket för att inte behöva
     *          ändra basklassen, kan dessutom lägga till fler och fler på det sättet
     *          Genom att ha interface på shoes och jacket kan jag lägga till underklasser, t ex boots, utan att röra Shoes eller jacket
     *
     * LSP      Shoes kommer att kunna vara
     *
     *          ProductInCatalog adidas = new Shoes();   
     *
     *          På det sättet får mina arv inga oväntade beteenden. Interface varianten är egentligen enklare men för att ha med ett LSP exempel
     *
     *  ISP     Varje interface är till en grej/syfte, just här till en klass
     */

    public class ProductInCatalog : IProductInCatalog
    {
        public string Id { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public Guid CatalogItemId { get; set; }

        public string ImgUrl { get; set; } =
            "https://images.pexels.com/photos/235621/pexels-photo-235621.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1";
    }
}
