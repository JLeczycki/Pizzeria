using System.Data.Entity;
using Pizzeria.Models;

namespace Pizzeria.Persistance
{
    /// <summary>
    /// Class ApplicationDbContext.
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Gets or sets the orders.
        /// </summary>
        /// <value>The orders.</value>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Gets or sets the ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public DbSet<Ingredient> Ingredients { get; set; }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>The products.</value>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the customers.
        /// </summary>
        /// <value>The customers.</value>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
        /// </summary>
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }
    }
}