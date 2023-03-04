namespace WebApiCoreLecture.DTO.EmployeeDTO
{
   public class EmployeeBasicInfoLandingPasignationDTO
   {
      public List<EmployeeBasicInfoLandingDataDTO> data { get; set; }
      public long currentPage { get; set; }
      public long totalCount { get; set; }
      public long pageSize { get; set; }
   }
}
