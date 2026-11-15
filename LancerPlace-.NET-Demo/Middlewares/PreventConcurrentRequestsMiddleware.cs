
using System.Security.Claims;
using System.Threading.RateLimiting;
using LancerPlace_.NET_Demo.Attributes;

namespace LancerPlace_.NET_Demo.Middlewares;
public class PreventConcurrentRequestsMiddleware : IMiddleware
{
    private static readonly PartitionedRateLimiter<HttpContext> Limiter =
        PartitionedRateLimiter.Create<HttpContext, string>(static context =>
        {
            var userId =
                context.User.FindFirstValue(ClaimTypes.NameIdentifier)
                ?? context.User.FindFirstValue("sub")
                ?? context.Connection.RemoteIpAddress?.ToString()
                ?? "anonymous";

            var endpoint = context.GetEndpoint();

            var route = endpoint is RouteEndpoint routeEndpoint
                ? routeEndpoint.RoutePattern.RawText
                : context.Request.Path.Value;

            var key = $"{userId}:{context.Request.Method}:{route}";

            return RateLimitPartition.GetConcurrencyLimiter(
                key,
                _ => new ConcurrencyLimiterOptions
                {
                    PermitLimit = 1,
                    QueueLimit = 0,
                    QueueProcessingOrder = QueueProcessingOrder.OldestFirst
                }
                );
        });

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var endpoint = context.GetEndpoint();

        if (endpoint?.Metadata.GetMetadata<PreventConcurrentRequestsAttribute>() is null)
        {
            await next(context);
            return;
        }

        using var lease = await Limiter.AcquireAsync(
            context,
            permitCount: 1,
            context.RequestAborted
        );

        if (!lease.IsAcquired)
        {
            context.Response.StatusCode = StatusCodes.Status409Conflict;

            await context.Response.WriteAsJsonAsync(new
            {
                ok = false,
                code = "REQUEST_IN_PROGRESS",
                message = "Another request is already being processed."
            });

            return;
        }

        await next(context);
    }
}
