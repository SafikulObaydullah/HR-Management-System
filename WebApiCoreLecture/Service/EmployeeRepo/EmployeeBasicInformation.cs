using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebApiCoreLecture.DTO.EmployeeDTO;
using WebApiCoreLecture.Helper;
using WebApiCoreLecture.Model;
using WebApiCoreLecture.Model.HRModel.EmployeeModel;
using WebApiCoreLecture.Service.IRepository;

namespace WebApiCoreLecture.Service.EmployeeRepo
{
   public class EmployeeBasicInformation : IEmployeeBasicInformation
   {
      public readonly EmployeeContext _context;
      public EmployeeBasicInformation(EmployeeContext context)
      {
         _context = context;
      }

      public async Task<MessageHelper> CreateEmployeeBasicInformation(CreateEmployeeBasicInfoDTO objCreate)
      {
         try
         {
            var details = new TblEmployeeBasicInfo()
            {
                   IntEmployeeId = 0,
                   strEmployeeCode = objCreate.EmployeeCode,
                   EmployeeFirstName = objCreate.EmployeeFirstName,
                   MiddleName = objCreate.EmployeeFirstName,
                   LastName = objCreate.EmployeeFirstName,
                   EmployeeFullName = objCreate.EmployeeFullName,
                   AccountId = objCreate.AccountId,
                   BusinessunitId = objCreate.BusinessunitId,
                   Sbuid = objCreate.Sbuid,
                   DepartmentId = objCreate.DepartmentId,
                   DesignationId = objCreate.DesignationId,
                   JoiningDate = objCreate.JoiningDate,
                   PresentAddress = objCreate.PresentAddress,
                   PermanentAddress = objCreate.PermanentAddress,
                   CountryId = objCreate.CountryId,
                   ContactNumber = objCreate.ContactNumber,
                   AlternativeContactNumber = objCreate.AlternativeContactNumber,
                   Email = objCreate.Email,
                   DateOfBirth = objCreate.DateOfBirth,
                   IdtypeId = objCreate.IdtypeId,
                   Idnumber = objCreate.Idnumber,
                   FatherName = objCreate.FatherName,
                   MotherName = objCreate.MotherName,
                   BloodGroupId = objCreate.BloodGroupId, 
                   UserGroupId = objCreate.UserGroupId,
                   SupervisorId = objCreate.SupervisorId,
                   CostCenterId = objCreate.CostCenterId,
                   WorkplaceGroupId = objCreate.WorkplaceGroupId,
                   PositionId = objCreate.PositionId,
                   EmpGradeId = objCreate.EmpGradeId,
                   EmploymentTypeId = objCreate.EmploymentTypeId,
                   LineManagerId = objCreate.LineManagerId,
                   LineManagerCode = objCreate.LineManagerCode,
                   EmploymentStatusId = objCreate.EmploymentStatusId,
                   ActionBy = objCreate.ActionBy,
                   BasicSalary = objCreate.BasicSalary,
                   GrossSalary = objCreate.GrossSalary,
            };

            await _context.TblEmployeeBasicInfos.AddAsync(details);
            await _context.SaveChangesAsync();

            var msg = new MessageHelper();
            msg.Message = "Employee Name: " + details.EmployeeFullName + ", Employee Code: " + details.strEmployeeCode;//"Processing" ;
            msg.statuscode = 200;
            return msg;
         }
         catch (Exception Ex)
         {
            throw Ex;
         }

      }
      //public async Task<MessageHelper> EditEmployeeBasicInfo(long id, CreateEmployeeBasicInfoDTO objCreate)
      //{
      //   if (id != objCreate.EmployeeId)
      //   {
      //      throw new Exception("Not Found");
      //   }

      //   _context.Entry(objCreate).State = EntityState.Modified;

      //   try
      //   {
      //      await _context.SaveChangesAsync();
      //   }
      //   catch (DbUpdateConcurrencyException)
      //   {
      //      if (!TblEmployeeExists(id))
      //      {
      //         throw new Exception("Not Found");
      //      }
      //      else
      //      {
      //         throw;
      //      }
      //   }

      //   throw new Exception("Not Found");
      //}
      public async Task<MessageHelper> EditEmployeeBasicInfo(CreateEmployeeBasicInfoDTO objCreate)
      {
         var data = _context.TblEmployeeBasicInfos.Where(x => x.IntEmployeeId == objCreate.EmployeeId).FirstOrDefault();
         if (data == null)
         {
            throw new Exception("Data Not Found");
         }
         data.strEmployeeCode = objCreate.EmployeeCode;
         data.EmployeeFirstName= objCreate.EmployeeFirstName;
         _context.TblEmployeeBasicInfos.Update(data);
         await _context.SaveChangesAsync();
         return new MessageHelper()
         {
            Message = "Successfully Updated",
            statuscode = 200,
         };
      }
      private bool TblEmployeeExists(long id)
      {
         return _context.TblEmployeeBasicInfos.Any(e => e.IntEmployeeId == id);
      }
   }
}
