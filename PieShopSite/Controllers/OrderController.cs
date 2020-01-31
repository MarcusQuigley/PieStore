using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieShopSite.Models;
using PieShopSite.Services;

namespace PieShopSite.Controllers
{
    public class OrderController : Controller
    {
        readonly IOrderRepository orderService;
        readonly ShoppingCart cart;
        public OrderController(IOrderRepository orderService, ShoppingCart cart)
        {
            this.orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            this.cart = cart ?? throw new ArgumentNullException(nameof(cart));
        }

        
        public IActionResult Checkout()
        {
             return View();
         }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (order == null)
            {
                return View();
            }
            var items = cart.GetShoppingCartItems();
            cart.ShoppingCartItems = items;
            if (!cart.ShoppingCartItems.Any())
            {
                ModelState.AddModelError("", "cart is empty, add pies.");
            }
            if (ModelState.IsValid)
            {
                orderService.CreateOrder(order);
                cart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutMessage = "Thanks for yo money, sucka!!";
            return View();
        }
    }
}