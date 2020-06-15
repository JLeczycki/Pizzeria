using System.Collections.Generic;
using System.Linq;
using Pizzeria.Interfaces;
using Pizzeria.Models;

namespace Pizzeria.Persistance
{
    /// <summary>
    /// OrderRepository
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        /// <summary>
        /// ApplicationDbContext
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Adds order
        /// </summary>
        /// <param name="order"></param>
        public void Add(Order order)
        {
            _context.Orders.Add(order);
        }

        /// <summary>
        /// Gets order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order GetOrder(int orderId)
        {
            return _context.Orders.SingleOrDefault(
                x => x.Id == orderId);
        }

        /// <summary>
        /// Gets list of orders
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }
    }
}