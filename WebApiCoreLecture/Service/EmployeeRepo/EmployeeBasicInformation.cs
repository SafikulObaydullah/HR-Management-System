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
         var editdata = _context.TblEmployeeBasicInfos.Where(x => x.IntEmployeeId == objCreate.EmployeeId).FirstOrDefault();
         if (editdata == null)
         {
            throw new Exception("Basic Information not found,Please Contact Admin or Your Line Manager");
         }
         editdata.strEmployeeCode = objCreate.EmployeeCode;
         editdata.EmployeeFirstName= objCreate.EmployeeFirstName;
         editdata.MiddleName = objCreate.MiddleName;
         editdata.LastName = objCreate.LastName;
         editdata.EmployeeFullName = objCreate.EmployeeFullName;
         editdata.DateOfBirth= objCreate.DateOfBirth;
         editdata.JoiningDate = objCreate.JoiningDate;
         editdata.Email = objCreate.Email;
         editdata.ContactNumber= objCreate.ContactNumber;
         editdata.AlternativeContactNumber= objCreate.AlternativeContactNumber;
         editdata.EmploymentStatusId= objCreate.EmploymentStatusId;
         editdata.EmpGradeId= objCreate.EmpGradeId;   
         editdata.FatherName= objCreate.FatherName;
         editdata.MotherName= objCreate.MotherName;
         editdata.AccountId = objCreate.AccountId;
         editdata.BasicSalary= objCreate.BasicSalary;
         editdata.BusinessunitId= objCreate.BusinessunitId;
         editdata.LineManagerId= objCreate.LineManagerId;
         editdata.GrossSalary= objCreate.GrossSalary;
         editdata.Idnumber= objCreate.Idnumber;
         editdata.WorkplaceGroupId= objCreate.WorkplaceGroupId;
         editdata.WorkplaceId= objCreate.WorkplaceId;
         editdata.DepartmentId= objCreate.DepartmentId;
         editdata.DesignationId= objCreate.DesignationId;
         editdata.EmploymentTypeId = objCreate.EmploymentTypeId;

         _context.TblEmployeeBasicInfos.Update(editdata);
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
