using PieShopSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopSite.Services
{
    public class OrderRepository : IOrderRepository
    {
        readonly PieContext dbContext;
        readonly ShoppingCart cart;
        public OrderRepository(PieContext dbContext, ShoppingCart cart)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.cart = cart ?? throw new ArgumentNullException(nameof(cart));
        }

        public void CreateOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }
            order.OrderPlaced = DateTime.Now;


            var cartItems = cart.ShoppingCartItems;
            order.OrderTotal = cart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();
            foreach (var item in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = item.Amount,
                    PieId = item.Pie.PieId,
                     Price = item.Pie.Price
                };
                order.OrderDetails.Add(orderDetail);
            }
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
 
        }
    }
}
