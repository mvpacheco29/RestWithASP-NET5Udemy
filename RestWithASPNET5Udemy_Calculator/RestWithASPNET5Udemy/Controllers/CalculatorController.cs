using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET5Udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("somar/{fisrtNumber}/{secondNumber}")]
        public IActionResult Somar(string fisrtNumber, string secondNumber)
        {
            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(fisrtNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("subtrair/{fisrtNumber}/{secondNumber}")]
        public IActionResult Subtrair(string fisrtNumber, string secondNumber)
        {
            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(fisrtNumber) - ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplicar/{fisrtNumber}/{secondNumber}")]
        public IActionResult Multiplicar(string fisrtNumber, string secondNumber)
        {
            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(fisrtNumber) * ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("dividir/{fisrtNumber}/{secondNumber}")]
        public IActionResult Dividir(string fisrtNumber, string secondNumber)
        {
            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(fisrtNumber) / ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("media/{fisrtNumber}/{secondNumber}")]
        public IActionResult Media(string fisrtNumber, string secondNumber)
        {
            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var sum = (ConvertToDecimal(fisrtNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("raizquadrada/{fisrtNumber}")]
        public IActionResult RaizQuadrada(string fisrtNumber)
        {
            if (IsNumeric(fisrtNumber))
            {
                var raizquadrada = Math.Sqrt((double)ConvertToDecimal(fisrtNumber));
                return Ok(raizquadrada.ToString());
            }
            return BadRequest("Invalid Input");
        }
        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }
        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return (decimalValue);
            }
            return 0;
        }


    }
}
