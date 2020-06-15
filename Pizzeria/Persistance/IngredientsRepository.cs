using System.Collections.Generic;
using System.Linq;
using Pizzeria.Interfaces;
using Pizzeria.Models;

namespace Pizzeria.Persistance
{
    /// <summary>
    /// IngredientsRepository
    /// </summary>
    public class IngredientsRepository : IIngredientsRepository
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly ApplicationDbContext _context;

        public IngredientsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds the specified ingredient.
        /// </summary>
        /// <param name="ingredient">The ingredient.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Add(Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
        }

        /// <summary>
        /// Gets the ingredient.
        /// </summary>
        /// <param name="ingredientId">The ingredient identifier.</param>
        /// <returns>Ingredient.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Ingredient GetIngredient(int ingredientId)
        {
            return _context.Ingredients.SingleOrDefault(
                x => x.Id == ingredientId);
        }

        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        /// <returns>IEnumerable&lt;Ingredient&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<Ingredient> GetIngredients()
        {
            return _context.Ingredients.ToList();
        }

        /// <summary>
        /// Removes ingredient
        /// </summary>
        /// <param name="ingredient"></param>
        public void Remove(Ingredient ingredient)
        {
            _context.Ingredients.Remove(ingredient);
        }
    }
}