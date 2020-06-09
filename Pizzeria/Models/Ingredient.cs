using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Models
{
    /// <summary>
    /// Class Ingredient.
    /// </summary>
    public class Ingredient
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        [Required]
        public double Price { get; set; }
    }
}