using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCoreLecture.DTO.EmployeeDTO;
using WebApiCoreLecture.Helper;
using WebApiCoreLecture.Model;
using WebApiCoreLecture.Service.IRepository;

namespace WebApiCoreLecture.Controllers.EmployeeInfo
{
   [Route("api/[controller]")]
   [ApiController]
   public class EmployeeBasicInformationController : ControllerBase
   {
      private readonly IEmployeeBasicInformation _IRepository;
      public EmployeeBasicInformationController(IEmployeeBasicInformation IRepository)
      {
         _IRepository = IRepository;
      }
      [HttpPost]
      [Route("CreateEmployeeBasicInformation")]
      public async Task<MessageHelper> CreateEmployeeBasicInformation(CreateEmployeeBasicInfoDTO objCreate)
      {
         try
         {
            var msg = await _IRepository.CreateEmployeeBasicInformation(objCreate);
            return msg;
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
      //[HttpPost]
      //[Route("EditEmployeeBasicInfo")]
      //public async Task<MessageHelper> EditEmployeeBasicInfo(long id, CreateEmployeeBasicInfoDTO objCreate)
      //{
      //   try
      //   {
      //      var msg = await _IRepository.EditEmployeeBasicInfo(id,objCreate);
      //      return msg;
      //   }
      //   catch (Exception ex)
      //   {
      //      throw ex;
      //   }
      //}
      [HttpPut]
      [Route("EditEmployeeBasicInfo")]
      public async Task<IActionResult> EditEmployeeBasicInfo(CreateEmployeeBasicInfoDTO objCreate)
      {
         var data = await _IRepository.EditEmployeeBasicInfo(objCreate);
         return Ok(data);
      }
      [HttpGet]
      [Route("")]
      [HttpPut]
      [Route("EmployeeBasicInfoOwnLanding")]
      public async Task<IActionResult> EmployeeBasicInfoOwnLanding(long EmployeeId)
      {
         var data = await _IRepository.EmployeeBasicInfoOwnLanding(EmployeeId);
         return Ok(data);
      }

   }
}
