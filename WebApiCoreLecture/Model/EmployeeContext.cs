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
      public virtual DbSet<TblCostCenter> TblCostCenter { get; set; }
      public virtual DbSet<TblCountry> TblCountry { get; set; }
      public virtual DbSet<TblDistrict> TblDistrict { get; set; }
      public virtual DbSet<TblDivision> TblDivision { get; set; }
      public virtual DbSet<TblEducationDegree> TblEducationDegree { get; set; }
      public virtual DbSet<TblEmployeeDepartment> TblEmployeeDepartment { get; set; }
      public virtual DbSet<TblEmployeeDesignation> TblEmployeeDesignation { get; set; }
   }
}
