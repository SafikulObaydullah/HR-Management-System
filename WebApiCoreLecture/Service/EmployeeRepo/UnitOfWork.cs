using OrderStore.Domain.Interfaces;
using WebApiCoreLecture.Model;

namespace WebApiCoreLecture.Service.EmployeeRepo
{
   public class UnitOfWork : IUnitOfWork
   {
      private readonly EmployeeContext _context;
      public IOrderRepository Orders { get; }
      public IProductRepository Products { get; }

      public UnitOfWork(EmployeeContext context,
          IOrderRepository ordersRepository,
          IProductRepository productRepository)
      {
         this._context = context;

         this.Orders = ordersRepository;
         this.Products = productRepository;
      }
      public int Complete()
      {
         return _context.SaveChanges();
      }
      public void Dispose()
      {
         Dispose(true);
         GC.SuppressFinalize(this);
      }
      protected virtual void Dispose(bool disposing)
      {
         if (disposing)
         {
            _context.Dispose();
         }
      }
   }
}
