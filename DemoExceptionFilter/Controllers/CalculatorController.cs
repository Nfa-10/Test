using DemoExceptionFilter.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoExceptionFilter.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[CalculatorExceptionFilter]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        [CalculatorExceptionFilter]
        public IActionResult Divide(int x, int y)
        {
            return Ok(x / y);
        }

        /*[HttpPost]
        public IActionResult DivideAgain(int x, int y)
        {
            return Ok(x / y);
        }*/

    }
}
