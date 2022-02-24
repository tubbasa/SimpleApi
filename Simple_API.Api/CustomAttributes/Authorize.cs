using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Simple_API.Api.Exceptions;
using Simple_API.Infrastructure.Services.Internal;

namespace Simple_API.Api.CustomAttributes
{
    public class Authorize : Attribute, IActionFilter
    {
        private AuthorizeService _authorizeService = new AuthorizeService();
       
        //Action attribute çalıştığında
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Headers["Auth"] == "")
            {
                context.Result = new UnauthorizedResult();
            }

            if (_authorizeService.CheckToken(context.HttpContext.Request.Headers["Auth"]))
            {
            }
            else
            {
                context.Result = new UnauthorizedResult();
            }
        }

        //Action attribute çalıştıktan sonra
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var output = context.Result;
        }
    }
}