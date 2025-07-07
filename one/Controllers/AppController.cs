using Microsoft.AspNetCore.Mvc;

namespace one.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppController(ILogger<AppController> logger) : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            if (logger.IsEnabled(LogLevel.Information)) { logger.LogInformation("ping"); }
            return Ok("TONG");
        }
    }
}
