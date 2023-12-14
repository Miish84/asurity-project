using ContactApi.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NuGet.Protocol;
using System.Net;

namespace ContactApi.Filters
{
    public class CustomExceptionFilter: IExceptionFilter
    {
        private readonly IHostEnvironment _hostEnvironment;

        public CustomExceptionFilter(IHostEnvironment hostEnvironment) =>
            _hostEnvironment = hostEnvironment;

        public void OnException(ExceptionContext context)
        {
            string responseMessage = context.Exception.Message ?? "Something went wrong. Please try again.";

            // Can add more detail in dev
            context.Result = new ContentResult
            {
                Content = new AppMessage(code: HttpStatusCode.BadRequest, customMessage: responseMessage, exceptionType: context.Exception.GetType()).ToJson()
            };
        }
    }
}
