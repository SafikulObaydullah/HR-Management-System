using System.ComponentModel.DataAnnotations;

namespace WebApiCoreLecture.Model.HRModel.EmployeeModel
{
   public class TblDivision
   {
      [Key]
      public long IntDivisionId { get; set; }
      public string StrDivisionGeocode { get; set; }
      public string StrDivision { get; set; }
      public long IntCountryId { get; set; }
      public string StrCountryName { get; set; }
      public bool? IsActive { get; set; }
      public string StrDivitionBanglaName { get; set; }
   }
}
