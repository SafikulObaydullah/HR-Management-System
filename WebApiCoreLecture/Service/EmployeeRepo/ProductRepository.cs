using OrderStore.Domain.Interfaces;
using OrderStore.Domain.Models;
using WebApiCoreLecture.Model;

namespace WebApiCoreLecture.Service.EmployeeRepo
{
   public class ProductRepository : GenericRepository<Product>, IProductRepository
   {
      public ProductRepository(EmployeeContext context) : base(context)
      {

      }
   }
}
