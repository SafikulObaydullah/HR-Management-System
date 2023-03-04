using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiCoreLecture.Model.HRModel.EmployeeModel
{
   public  class TblEmployeeBasicInfo
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntEmployeeId { get; set; }
      public string? strEmployeeCode { get; set; } = "";
      [Required]
      [StringLength(50)]
      public string? EmployeeFirstName { get; set; }
      public string? MiddleName { get; set; }
      public string? LastName { get; set; }
      public string? EmployeeFullName { get; set; }
      public long? AccountId { get; set; }
      public long? BusinessunitId { get; set; }
      public long? Sbuid { get; set; }
      public long? DepartmentId { get; set; }
      public long? DesignationId { get; set; }
      public DateTime? JoiningDate { get; set; }
      public string? PresentAddress { get; set; }
      public string? PermanentAddress { get; set; }
      public long? CountryId { get; set; }
      public string? ContactNumber { get; set; }
      public string? AlternativeContactNumber { get; set; }
      public string? Email { get; set; }
      public DateTime? DateOfBirth { get; set; }
      public long? IdtypeId { get; set; }
      public string? Idnumber { get; set; }
      public string? FatherName { get; set; }
      public string? MotherName { get; set; }
      public long? BloodGroupId { get; set; }
      public long? UserGroupId { get; set; }
      public long? SupervisorId { get; set; }
      public long? CostCenterId { get; set; }
      public long? WorkplaceGroupId { get; set; }
      public long? WorkplaceId { get; set; }
      public long? PositionId { get; set; }
      public long? EmpGradeId { get; set; }
      public long? EmploymentTypeId { get; set; }
      public long? LineManagerId { get; set; }
      public string? LineManagerCode { get; set; }
      public long? EmploymentStatusId { get; set; }
      public long? ActionBy { get; set; }
      public decimal? BasicSalary { get; set; }
      public decimal? GrossSalary { get; set; }
   }
}
