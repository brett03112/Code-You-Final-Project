using System.Net;
using System.Text.Json;

namespace HolidayDessertStore.API.Middleware
{
    /*
    Class Overview: The ErrorHandlingMiddleware class is a middleware component that handles unhandled 
        exceptions in the request pipeline, logging the error and returning a JSON response with an error object.

    Class Methods:

        ** ErrorHandlingMiddleware(RequestDelegate next, ILogger logger) **: The constructor initializes the middleware 
        instance with the next request delegate in the pipeline and an instance of the logger to log errors.

        ** InvokeAsync(HttpContext context) **: This method invokes the middleware to handle errors in the request 
        pipeline. It tries to execute the next request delegate and catches any exceptions, logging the error and 
        calling HandleExceptionAsync to handle the exception.

        ** HandleExceptionAsync(HttpContext context, Exception exception) **: This method handles unhandled exceptions by 
        writing a JSON response with an error object containing the exception's message and HTTP status code.
    */
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;

        /// <summary>
        /// Creates an instance of the <see cref="ErrorHandlingMiddleware"/>.
        /// </summary>
        /// <param name="next">The next <see cref="RequestDelegate"/> in the pipeline.</param>
        /// <param name="logger">An instance of <see cref="ILogger{TCategoryName}"/> to log any errors to.</param>
        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        /// <summary>
        /// Invokes the middleware to handle errors in the request pipeline.
        /// </summary>
        /// <param name="context">The <see cref="HttpContext"/> of the current request.</param>
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                await HandleExceptionAsync(context, ex);
            }
        }
        
        /// <summary>
        /// Handles any unhandled exceptions by writing a JSON response with an error object,
        /// which contains the exception's message and the HTTP status code.
        /// </summary>
        /// <param name="context">The <see cref="HttpContext"/> of the current request.</param>
        /// <param name="exception">The exception that should be handled.</param>
        /// <returns>A <see cref="Task"/> that completes when the response has been written.</returns>
        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = exception switch
            {
                KeyNotFoundException => (int)HttpStatusCode.NotFound,
                UnauthorizedAccessException => (int)HttpStatusCode.Unauthorized,
                ArgumentException => (int)HttpStatusCode.BadRequest,
                _ => (int)HttpStatusCode.InternalServerError
            };

            var response = new
            {
                error = new
                {
                    message = exception.Message,
                    statusCode = context.Response.StatusCode
                }
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}
