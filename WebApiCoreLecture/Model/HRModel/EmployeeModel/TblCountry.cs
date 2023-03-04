using System.ComponentModel.DataAnnotations;

namespace WebApiCoreLecture.Model.HRModel.EmployeeModel
{
   public class TblCountry
   {
      [Key]
      public long IntCountryId { get; set; }
      public string StrCountryCode { get; set; }
      public string StrDialingCode { get; set; }
      public string StrCountryName { get; set; }
      public long IntActionBy { get; set; }
      public DateTime DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
   }
}
