using System.ComponentModel.DataAnnotations;

namespace WebApiCoreLecture.Model.HRModel.EmployeeModel
{
   public class TblEducationDegree
   {
      [Key]
      public long IntEducationDegreeId { get; set; }
      public string StrEducationDegree { get; set; }
      public long IntLevelOfEducationId { get; set; }
      public string StrLevelOfEducation { get; set; }
      public bool IsActive { get; set; }
   }
}
