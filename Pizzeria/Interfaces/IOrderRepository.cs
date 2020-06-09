using System.Collections.Generic;
using Pizzeria.Models;

namespace Pizzeria.Interfaces
{
    public interface IOrderRepository
    {
        /// <summary>
        /// Adds the specified order.
        /// </summary>
        /// <param name="order">The order.</param>
        void Add(Order order);
    }
}