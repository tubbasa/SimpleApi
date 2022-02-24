using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Simple_API.Api.Exceptions;

namespace Simple_API.Api.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            ApiResponse response;
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                switch (ex)
                {
                    case TokenException tokenexp:
                        response = new ApiResponse(ex.Message, StatusCodes.Status401Unauthorized);
                        break;
                    case Simple_API.Infrastructure.Exceptions.FileWriteError fileWriteExp:
                        response = new ApiResponse(ex.Message, StatusCodes.Status500InternalServerError);
                        break;
                    default:
                        response = new ApiResponse(ex.Message, StatusCodes.Status500InternalServerError);
                        break;
                        
                }
                
                if (!httpContext.Response.HasStarted)
                {
                    httpContext.Response.ContentType = "application/json";
                    httpContext.Response.StatusCode = response.StatusCode;
                    var json = JsonConvert.SerializeObject(response);
                    await httpContext.Response.WriteAsync(json);
                }
            }

          
        }
    }
}