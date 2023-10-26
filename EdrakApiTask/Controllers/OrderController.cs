using EdrakApiTask.BL;
using EdrakApiTask.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EdrakApiTask.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(Policy = nameof(Roles.Admin))]
    public class OrderController : ControllerBase
    {
        private readonly IOrderCustomer _OrderManager;

        public OrderController(IOrderCustomer OrderManager)
        {
            _OrderManager = OrderManager;
        }


        [HttpGet]
        [AllowAnonymous]
        public ActionResult<IEnumerable<OrderReadDTO>> GetAllCategories()=> Ok( _OrderManager.GetAll);


        [HttpGet("{id}")]
        [AllowAnonymous]
        public ActionResult<OrderReadDTO> GetOrderById(int id) => Ok(_OrderManager.GetOrder(id));



        [HttpPost]
        public ActionResult<OrderCreateDTO> CreateOrder(OrderCreateDTO OrderCreateDTO)
        {
             _OrderManager.CreateOrder(OrderCreateDTO);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            _OrderManager.DeleteOrder(id);
            return NoContent();
        }


        [HttpPut("{id}")]
        public ActionResult<OrderUpdateDTO> UpdateOrder(int id,OrderUpdateDTO OrderUpdateDTO)
        {
             _OrderManager.UpdateOrder(id,OrderUpdateDTO);
             return NoContent();
        }

  
    }
}
