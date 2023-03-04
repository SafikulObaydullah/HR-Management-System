using System.ComponentModel.DataAnnotations;

namespace WebApiCoreLecture.Model.HRModel.EmployeeModel
{
   public class TblCostCenter
   {
      [Key]
      public long IntCostCenterId { get; set; }
      public string StrCostCenterCode { get; set; }
      public string StrCostCenterName { get; set; }
      public long IntCostCenterTypeId { get; set; }
      public long IntControllingUnitId { get; set; }
      public long IntProfitCenterId { get; set; }
      public long IntSbuid { get; set; }
      public long IntCostCenterGroupId { get; set; }
      public long IntResponsiblePersonId { get; set; }
      public long IntAccountId { get; set; }
      public long IntBusinessUnitId { get; set; }
      public long IntActionBy { get; set; }
      public DateTime DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
   }
}
