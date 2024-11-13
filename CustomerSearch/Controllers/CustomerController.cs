using Microsoft.AspNetCore.Mvc;

namespace CustomerSearch.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet("search")]
        public IActionResult SearchCustomer()
        {
            return Ok("Customer search successful!");
        }
    }
}
