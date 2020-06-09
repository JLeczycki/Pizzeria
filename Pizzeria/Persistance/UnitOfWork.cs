using Pizzeria.Interfaces;

namespace Pizzeria.Persistance
{
    /// <summary>
    /// Class UnitOfWork.
    /// </summary>
    /// <seealso cref="Pizzeria.Interfaces.IUnitOfWork" />
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Gets the orders repository.
        /// </summary>
        /// <value>The orders repository.</value>
        public IOrderRepository OrdersRepository { get; private set; }

        /// <summary>
        /// Gets the ingredients repository.
        /// </summary>
        /// <value>The ingredients repository.</value>
        public IIngredientsRepository IngredientsRepository { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            OrdersRepository = new OrderRepository();
            IngredientsRepository = new IngredientsRepository(context);
        }

        /// <summary>
        /// Completes this instance.
        /// </summary>
        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}