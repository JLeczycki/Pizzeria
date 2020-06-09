using System.Web.Mvc;
using Pizzeria.Interfaces;
using Pizzeria.Models;
using Pizzeria.ViewModels;

namespace Pizzeria.Controllers
{
    /// <summary>
    /// Class IngredientsController.
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class IngredientsController : Controller
    {
        /// <summary>
        /// The unit of work
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        public IngredientsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Creates the specified view model.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <returns>ActionResult.</returns>
        public ActionResult Create(IngredientFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("IngredientForm", viewModel);
            }

            var ingredient = new Ingredient
            {
                Name = viewModel.Name,
                Price = viewModel.Price
            };

            _unitOfWork.IngredientsRepository.Add(ingredient);
            _unitOfWork.Complete();

            return RedirectToAction("IngredientsList", "Ingredients");
        }

        /// <summary>
        /// Ingredients the list.
        /// </summary>
        /// <returns>Returns list of ingredients.</returns>
        [HttpGet]
        public ActionResult IngredientsList()
        {
            var ingredientsList = _unitOfWork
                .IngredientsRepository.GetIngredients();

            return View(ingredientsList);
        }
    }
}