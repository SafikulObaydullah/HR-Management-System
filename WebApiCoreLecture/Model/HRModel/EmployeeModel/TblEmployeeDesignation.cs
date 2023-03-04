using System.ComponentModel.DataAnnotations;

namespace WebApiCoreLecture.Model.HRModel.EmployeeModel
{
   public class TblEmployeeDesignation
   {
      [Key]
      public long IntDesignationId { get; set; }
      public string StrDesignationCode { get; set; }
      public string StrDesignationName { get; set; }
      public long? IntAccountId { get; set; }
      public long? IntBusinessUnitId { get; set; }
      public long? IntPosionId { get; set; }
      public string SrtPositionName { get; set; }
      public bool? IsManagement { get; set; }
      public string StrRemarks { get; set; }
      public long? IntActionBy { get; set; }
      public DateTime? DteLastActionDateTime { get; set; }
      public DateTime? DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
   }
}
