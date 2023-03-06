using Microsoft.EntityFrameworkCore;
using OrderStore.Domain.Interfaces;
using WebApiCoreLecture.Model;

namespace WebApiCoreLecture.Service.EmployeeRepo
{
   public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
   {
      protected readonly EmployeeContext _context;

      protected GenericRepository(EmployeeContext context)
      {
         _context = context;
      }

      public async Task<T> Get(int id)
      {
         return await _context.Set<T>().FindAsync(id);
      }

      public async Task<IEnumerable<T>> GetAll()
      {
         return await _context.Set<T>().ToListAsync();
      }

      public async Task Add(T entity)
      {
         await _context.Set<T>().AddAsync(entity);
      }

      public void Delete(T entity)
      {
         _context.Set<T>().Remove(entity);
      }

      public void Update(T entity)
      {
         _context.Set<T>().Update(entity);
      }
   }
}
