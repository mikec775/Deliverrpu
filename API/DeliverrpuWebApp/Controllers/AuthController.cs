using Microsoft.AspNetCore.Mvc;

namespace DeliverrpuWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        public AuthController()
        {

        }

        [HttpGet(Name = "Login")]
        public ActionResult<WeatherForecast> Login([FromBody] string username, string password)
        {
            return Ok();
        }
    }
}
