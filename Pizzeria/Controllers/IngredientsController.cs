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

        /// <summary>
        /// EditIngredient
        /// </summary>
        /// <param name="id"></param>
        /// <returns>View for ingredient form</returns>
        public ActionResult EditIngredient(int id)
        {
            var ingredient = _unitOfWork.IngredientsRepository.GetIngredient(id);

            if (ingredient == null)
            {
                return HttpNotFound();
            }
            var viewModel = new IngredientFormViewModel
            {
                Name = ingredient.Name,
                Price = ingredient.Price
            };

            return View("IngredientForm", viewModel);
        }

        /// <summary>
        /// Removes ingredient
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Ingredient list after remove</returns>
        public ActionResult RemoveIngredient(int id)
        {
            var inggredient = _unitOfWork.IngredientsRepository.GetIngredient(id);

            if (inggredient == null)
            {
                return HttpNotFound();
            }

            _unitOfWork.IngredientsRepository.Remove(inggredient);
            _unitOfWork.Complete();

            return RedirectToAction("IngredientsList", "Ingredients");
        }
    }
}