using MathHelpers;
using Microsoft.AspNetCore.Mvc;
using Sorts;
using System.Diagnostics;

namespace Ds.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Dummy")]
        public string Dummy()
        {
            return "Dummy";
        }
    }
}
