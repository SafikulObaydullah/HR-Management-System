using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderStore.Domain.Interfaces;
using OrderStore.Domain.Models;

namespace WebApiCoreLecture.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class OrderController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      public OrderController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
      }
      [HttpPost(nameof(CreateOrderse))]
      public IActionResult CreateOrderse(Order order)
      {
         var result = _unitOfWork.Orders.Add(order);
         _unitOfWork.Complete();
         if (result is not null)
         { 
            return Ok("Order Created");
         }
         else return BadRequest("Error in Creating the Order");
      }
      // GET: api/<Books>
      [HttpGet(nameof(GetOrders))]
      public async Task<IActionResult> GetOrders() => Ok(await _unitOfWork.Orders.GetAll());
      [HttpGet(nameof(GetByIdOrders))]
      public async Task<IActionResult> GetByIdOrders(int id)
      {
         var data = await _unitOfWork.Orders.Get(id);
         if (id == 0)
         { 
            return BadRequest("Error in Order GetbyId");
         }
        return Ok(data);
      }
      //[HttpGet(nameof(GetOrderByName))]
      //public async Task<IActionResult> GetOrderByName([FromQuery] string Genre)
      //   => Ok(await _unitOfWork.Orders.GetOrdersByOrderName(Genre));
      [HttpGet(nameof(GetOrderByName))]
      public async Task<IActionResult> GetOrderByName([FromQuery] string Genre)
      {
         return Ok(await _unitOfWork.Orders.GetOrdersByOrderName(Genre));
      }
   }
}
