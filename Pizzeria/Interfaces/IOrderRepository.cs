using System.Collections.Generic;
using Pizzeria.Models;

namespace Pizzeria.Interfaces
{
    /// <summary>
    /// IOrderRepository
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// Adds the specified order.
        /// </summary>
        /// <param name="order">The order.</param>
        void Add(Order order);

        /// <summary>
        /// GetsOrder
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>Order</returns>
        Order GetOrder(int orderId);

        /// <summary>
        /// GetOrders
        /// </summary>
        /// <returns>Orders</returns>
        IEnumerable<Order> GetOrders();
    }
}