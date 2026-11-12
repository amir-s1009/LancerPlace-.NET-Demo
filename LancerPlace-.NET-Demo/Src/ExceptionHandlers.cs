using Microsoft.AspNetCore.Diagnostics;

namespace LancerPlace_.NET_Demo.Src;

public class GlobalExceptionHandler(
    ILogger<GlobalExceptionHandler> logger
) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        var (code, message) = exception switch
        {
            ApplicationException ex => ((int)ex.Code, ex.Message),

            DomainException ex => (
                StatusCodes.Status400BadRequest,
                ex.Message
            ),

            _ => (
                StatusCodes.Status500InternalServerError,
                "خطای داخلی سرور رخ داد."
            )
        };

        if (code >= 500)
            logger.LogError(exception, "Unhandled exception occurred.");
        else
            logger.LogWarning(exception, "{Message}", message);

        httpContext.Response.Clear();
        httpContext.Response.StatusCode = code;

        await httpContext.Response.WriteAsJsonAsync(
            new CustomResult(
                false,
                code,
                message
            ),
            cancellationToken
        );

        return true;
    }
}