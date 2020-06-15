using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Web.Mvc;
using Antlr.Runtime.Misc;
using Pizzeria.Controllers;

namespace Pizzeria.ViewModels
{
    /// <summary>
    /// Class IngredientFormViewModel.
    /// </summary>
    public class IngredientFormViewModel
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
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        [Required]
        public double Price { get; set; }

        /// <summary>
        /// Gets the action.
        /// </summary>
        /// <value>The action.</value>
        public string Action
        {
            get
            {
                Expression<Func<IngredientsController, ActionResult>> create = x => x.Create(this);
                var action =  create;
                return (action.Body as MethodCallExpression)?.Method.Name;
            }
        }
    }
}