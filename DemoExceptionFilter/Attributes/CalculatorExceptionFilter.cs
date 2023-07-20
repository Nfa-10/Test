﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DemoExceptionFilter.Attributes
{
    public class CalculatorExceptionFilter :ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var ex=context.Exception;

            context.Result = new OkObjectResult(new { err = true, errDesc = ex.Message });
        }
    }
}
