using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCoreLecture.Model;

namespace WebApiCoreLecture.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class DesignationController : ControllerBase
   {
      private readonly EmployeeContext _context;
      public DesignationController(EmployeeContext context)
      {
         _context = context;
      }
      // GET: api/lDesignation
      [HttpGet]
      public async Task<ActionResult<IEnumerable<TblDesignation>>> GetTblDesignation()
      {
         return await _context.TblDesignation.ToListAsync();
      }
      [HttpPost]
      [Route("CreateDesignation")]
      public async Task<IActionResult> CreateDesignation(TblDesignation obj)
      {
         if (obj == null)
         {
            throw new ArgumentNullException(nameof(obj));
         }
         TblDesignation model = new TblDesignation()
         {
            Designation = obj.Designation,
         };
         _context.TblDesignation.AddAsync(model);
         _context.SaveChanges();
         return Ok();
      }
   }
 }
