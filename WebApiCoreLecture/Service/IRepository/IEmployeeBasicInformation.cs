using WebApiCoreLecture.DTO.EmployeeDTO;
using WebApiCoreLecture.Helper;

namespace WebApiCoreLecture.Service.IRepository
{
   public interface IEmployeeBasicInformation
   {
      public Task<MessageHelper> CreateEmployeeBasicInformation(CreateEmployeeBasicInfoDTO objCreate);
      //public Task<MessageHelper> EditEmployeeBasicInfo(long id, CreateEmployeeBasicInfoDTO objCreate);
      public Task<MessageHelper> EditEmployeeBasicInfo(CreateEmployeeBasicInfoDTO objCreate);
      public Task<EmployeeBasicInfoLandingPasignationDTO> EmployeeBasicInfoOwnLanding(long employeeId);
   }
}
