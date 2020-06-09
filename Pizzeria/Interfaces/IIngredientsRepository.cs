using System.Collections.Generic;
using Pizzeria.Models;

namespace Pizzeria.Interfaces
{
    /// <summary>
    /// Interface IIngredientsRepository
    /// </summary>
    public interface IIngredientsRepository
    {
        /// <summary>
        /// Adds the specified ingredient.
        /// </summary>
        /// <param name="ingredient">The ingredient.</param>
        void Add(Ingredient ingredient);

        /// <summary>
        /// Gets the ingredient.
        /// </summary>
        /// <param name="ingredientId">The ingredient identifier.</param>
        /// <returns>Ingredient.</returns>
        Ingredient GetIngredient(int ingredientId);

        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        /// <returns>IEnumerable&lt;Ingredient&gt;.</returns>
        IEnumerable<Ingredient> GetIngredients();
    }
}