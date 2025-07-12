using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace EmployeeWebApi.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly IWebHostEnvironment _env;

        public CustomExceptionFilter(IWebHostEnvironment env)
        {
            _env = env;
        }

        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var logPath = Path.Combine(_env.ContentRootPath, "Logs");

            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);

            var filePath = Path.Combine(logPath, "errors.txt");

            var logMessage = $"[{DateTime.Now}] Exception: {exception.Message}\nStackTrace: {exception.StackTrace}\n";
            File.AppendAllText(filePath, logMessage);

            context.Result = new ObjectResult("Something went wrong. Please contact support.")
            {
                StatusCode = 500
            };

            context.ExceptionHandled = true;
        }
    }
}
