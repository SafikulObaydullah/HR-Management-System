using Microsoft.EntityFrameworkCore;
using WebApiCoreLecture.Model.HRModel.EmployeeModel;

namespace WebApiCoreLecture.Model
{
   public class EmployeeContext : DbContext
   {
      public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
      {
      }
      public DbSet<TblEmployee> TblEmployee { get; set; }
      public DbSet<TblDesignation> TblDesignation { get; set; }
      public DbSet<TblEmployeeBasicInfo> TblEmployeeBasicInfos { get; set; }
   }
}
