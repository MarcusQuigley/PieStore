using PieShopSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopSite.ViewModels
{
    public class CartViewModel
    {
       public ShoppingCart Cart { get; set; }
        public decimal Total { get;   set; }
    }
}
