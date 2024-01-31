using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        public ActionResult<decimal> Add(decimal num1, decimal num2)
        {
            decimal sum = num1 + num2;
            return Ok(sum);
        }

        public ActionResult<decimal> Subtract(decimal num1, decimal num2)
        {
            decimal difference = num1 - num2;
            return Ok(difference);
        }

        public ActionResult<decimal> Multiply(decimal num1, decimal num2)
        {
            decimal product = num1 * num2;
            return Ok(product);
        }

        public ActionResult<decimal> Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Cannot divide by zero.");
            }

            decimal quotient = num1 / num2;
            return Ok(quotient);
        }

        public ActionResult<decimal> Modulo(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Cannot calculate modulo with zero divisor.");
            }

            decimal remainder = num1 % num2;
            return Ok(remainder);
        }
    }
}
// CalculatorController.cs
