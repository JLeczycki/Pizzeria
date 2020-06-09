using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Models
{
    /// <summary>
    /// Class Customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        [Required]
        [StringLength(255)]
        public string TableName { get; set; }
    }
}