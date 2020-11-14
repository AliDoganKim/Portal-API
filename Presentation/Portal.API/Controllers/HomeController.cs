using Microsoft.AspNetCore.Mvc;

namespace Portal.API.Controllers
{
    public class HomeController : ControllerBase
    {
        [HttpGet("Test")]
        public IActionResult Index()
        {
            return Ok("Swagger testi içindir.");
        }
    }
}