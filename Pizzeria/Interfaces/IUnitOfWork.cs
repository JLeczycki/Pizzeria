namespace Pizzeria.Interfaces
{
    /// <summary>
    /// Interface IUnitOfWork
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Gets the orders repository.
        /// </summary>
        /// <value>The orders repository.</value>
        IOrderRepository OrdersRepository { get; }

        /// <summary>
        /// Gets the ingredients repository.
        /// </summary>
        /// <value>The ingredients repository.</value>
        IIngredientsRepository IngredientsRepository { get; }

        /// <summary>
        /// Completes this instance.
        /// </summary>
        void Complete();
    }
}