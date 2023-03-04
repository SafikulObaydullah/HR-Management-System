using System.ComponentModel.DataAnnotations;

namespace WebApiCoreLecture.Model.HRModel.EmployeeModel
{
   public class TblEmployeeDepartment
   {
      [Key]
      public long IntDepartmentId { get; set; }
      public string StrDepartmentCode { get; set; }
      public string StrDepartmentName { get; set; }
      public long? IntAccountId { get; set; }
      public long? IntBusinessUnitId { get; set; }
      public string StrRemarks { get; set; }
      public long? IntActionBy { get; set; }
      public DateTime? DteLastActionDateTime { get; set; }
      public DateTime? DteServerDateTime { get; set; }
      public bool? IsCorporate { get; set; }
      public bool? IsActive { get; set; }
   }
}
