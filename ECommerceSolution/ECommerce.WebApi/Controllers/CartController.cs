using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        // Placeholder controller
        [HttpGet]
        public IActionResult GetCart()
        {
            return Ok();
        }
    }
}
