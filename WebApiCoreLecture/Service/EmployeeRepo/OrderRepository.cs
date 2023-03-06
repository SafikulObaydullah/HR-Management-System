using Microsoft.EntityFrameworkCore;
using OrderStore.Domain.Interfaces;
using OrderStore.Domain.Models;
using WebApiCoreLecture.Model;

namespace WebApiCoreLecture.Service.EmployeeRepo
{
   public class OrderRepository : GenericRepository<Order>, IOrderRepository
   {
      public OrderRepository(EmployeeContext context) : base(context)
      {

      }
      public async Task<IEnumerable<Order>> GetOrdersByOrderName(string orderName)
      {
         return await _context.Orders.Where(c => c.OrderDetails.Contains(orderName)).ToListAsync();
      }
   }
}
