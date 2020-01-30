using Microsoft.AspNetCore.Mvc;
using PieShopSite.Models;
using PieShopSite.Services;
using PieShopSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopSite.Controllers
{
    public class CartController : Controller
    {
        readonly ShoppingCart cart;
        readonly IPieRepository pieService;
        public CartController(ShoppingCart cart, IPieRepository pieService)
        {
            this.cart = cart ?? throw new ArgumentNullException(nameof(cart));
            this.pieService = pieService ?? throw new ArgumentNullException(nameof(pieService));
        }

        public IActionResult Index() {

            var items = cart.GetShoppingCartItems();
            cart.ShoppingCartItems = items;
            var cartVM = new CartViewModel 
            { 
                Cart = cart,
                Total = cart.GetShoppingCartTotal()
            };
            return View(cartVM);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var pie = pieService.GetPie(id);
            if (pie != null)
            {
                cart.AddToCart(pie, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromCart(int pieId)
        {
            var pie = pieService.GetPie(pieId);
            if (pie != null)
            {
                cart.RemoveFromCart(pie);
            }
            return RedirectToAction("Index");
        }
    }
}
