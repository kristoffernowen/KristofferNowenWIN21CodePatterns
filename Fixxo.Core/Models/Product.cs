﻿using Fixxo.Core.Interface.Models;

namespace Fixxo.Core.Models
{


    /* OCP    Product implementerar IProduct så alla products kan vara i en lista
     *          Jag förlänger Product med arv in i t ex Shoes och Jacket för att inte behöva
     *          ändra basklassen, kan dessutom lägga till fler och fler på det sättet
     *          Genom att ha interface på shoes och jacket kan jag lägga till underklasser, t ex boots, utan att röra Shoes eller jacket
     *
     * LSP      Shoes kommer att kunna vara
     *
     *          Product adidas = new Shoes();   
     *
     *          På det sättet får mina arv inga oväntade beteenden. Interface varianten är egentligen enklare men för att ha med ett LSP exempel
     *
     *  ISP     Varje interface är till en grej/syfte
     */

    public class Product : IProduct
    {
        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
    }
}
