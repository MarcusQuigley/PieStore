using Microsoft.AspNetCore.Mvc;
using PieShopSite.Models;
using PieShopSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopSite.Components
{
    public class CartSummary : ViewComponent
    {
        readonly ShoppingCart cart;

        public CartSummary(ShoppingCart cart)
        {
            this.cart = cart ?? throw new ArgumentNullException(nameof(cart));
        }
        
        public IViewComponentResult Invoke()
        {
            var items = cart.GetShoppingCartItems();
            cart.ShoppingCartItems = items;

            var cartVm = new CartViewModel()
            {
                Cart = cart,
                Total = cart.GetShoppingCartTotal()
            };
            return View(cartVm);
        }
    }
}
