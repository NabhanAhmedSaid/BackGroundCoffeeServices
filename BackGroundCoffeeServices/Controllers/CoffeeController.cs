using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackGroundCoffeeServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("OrderCoffee")]
        public string Get()
        {
            return "Coffee is ready";
        }
    }
}
