using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET5Udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{fisrtNumber}/{secondNumber}")]
        public IActionResult Sum(string fisrtNumber, string secondNumber)
        {
            return BadRequest("Invalid Input");
        }

    }
}
