namespace WebApiCoreLecture.Model.HRModel.EmployeeModel
{
   public class TblBusinessUnit
   {
      public long IntBusinessUnitId { get; set; }
      public long IntAccountId { get; set; }
      public string StrBusinessUnitCode { get; set; }
      public string StrBusinessUnitName { get; set; }
      public string StrBusinessUnitAddress { get; set; }
      public long IntActionBy { get; set; }
      public DateTime DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
      public bool? IsAttendanceDataProceed { get; set; }
      public string StrImage { get; set; }
      public string StrRegistrationNo { get; set; }
      public DateTime? DteRegistrationDate { get; set; }
      public string StrMasking { get; set; }
      public string StrBusinessUnitGroupName { get; set; }
      public bool? IsVatExempted { get; set; }
   }
}
