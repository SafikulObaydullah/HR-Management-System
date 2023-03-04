namespace WebApiCoreLecture.DTO.EmployeeDTO
{
   public class EmployeeBasicInfoLandingDataDTO
   {
      public long Sl { get; set; }
      public long? ErpemployeeId { get; set; }
      public long EmployeeId { get; set; }
      public string EmployeeCode { get; set; }
      public string EmployeeFirstName { get; set; }
      public string MiddleName { get; set; }
      public string LastName { get; set; }
      public string EmployeeFullName { get; set; }
      public long? AccountId { get; set; }
      public long? BusinessunitId { get; set; }
      public string BusinessunitName { get; set; }
      public string EmploymentStatus { get; set; }
      public long? Sbuid { get; set; }
      public string sbuName { get; set; }
      public long? DepartmentId { get; set; }
      public string Department { get; set; }
      public long? DesignationId { get; set; }
      public string DesignationName { get; set; }
      public DateTime? JoiningDate { get; set; }
      public string PresentAddress { get; set; }
      public string PermanentAddress { get; set; }
      public string CostCenter { get; set; }
      public long? CountryId { get; set; }
      public string ContactNumber { get; set; }
      public string AlternativeContactNumber { get; set; }
      public string Email { get; set; }
      public DateTime? DateOfBirth { get; set; }
      public long? IdtypeId { get; set; }
      public string Idnumber { get; set; }
      public string FatherName { get; set; }
      public string MotherName { get; set; }
      public long? BloodGroupId { get; set; }
      public long? UserGroupId { get; set; }
      public long? SupervisorId { get; set; }
      public string? SupervisorName { get; set; }
      public long? CostCenterId { get; set; }
      public string CostCenterName { get; set; }
      public long? WorkplaceGroupId { get; set; }
      public long? WorkplaceId { get; set; }
      public long? PositionId { get; set; }
      public string PositionName { get; set; }
      public long? EmpGradeId { get; set; }
      public long? EmploymentTypeId { get; set; }
      public long? LineManagerId { get; set; }
      public string LineManagerName { get; set; }
      public long? EmploymentStatusId { get; set; }
      public long? ActionBy { get; set; }

      //Table Status
      public bool? EmployeePersonalInfoStatus { get; set; }
      public bool? EmployeePersonalContactInfoStatus { get; set; }
      public bool? EmployeeWorkExperienceInfoStatus { get; set; }
      public bool? EmployeeFamilyInfoStatus { get; set; }
      public bool? EmployeeOthersContactInfoStatus { get; set; }
      public bool? EmployeeEducationInfoStatus { get; set; }
      public bool? EmployeeTrainigInfoStatus { get; set; }
      public bool? EmployeeNomineeInfoStatus { get; set; }
      //for new entity
      public bool? EmployeBankInformationStatus { get; set; }
      public bool? EmployeeBasicInfoStatus { get; set; }
      public bool? EmployeeAdministrativeInfoStatus { get; set; }
      public bool? EmployeeRemunerationSetupRowStatus { get; set; }

      public DateTime? SeparationDate { get; set; }
      public string? SeparationReason { get; set; }
      public long? SectionId { get; set; }
      public string? SectionName { get; set; }
   }
}
