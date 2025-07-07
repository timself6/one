using Microsoft.AspNetCore.Mvc;

namespace one.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OneController(ILogger<OneController> logger) : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok("TONG");
        }
    }
}
