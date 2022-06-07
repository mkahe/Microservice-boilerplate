using Microsoft.AspNetCore.Mvc;

namespace MeKa.Api.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get() => Content("Hello!");
    }
}