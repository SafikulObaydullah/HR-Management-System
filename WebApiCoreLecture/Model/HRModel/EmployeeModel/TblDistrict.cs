using System.ComponentModel.DataAnnotations;

namespace WebApiCoreLecture.Model.HRModel.EmployeeModel
{
   public class TblDistrict
   {
      [Key]
      public long IntDistrictId { get; set; }
      public long IntDivisionId { get; set; }
      public string StrDistrictGeocode { get; set; }
      public string StrDistrictName { get; set; }
      public long IntCountryId { get; set; }
      public long IntActionBy { get; set; }
      public DateTime DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
   }
}
