using LancerPlace_.NET_Demo.Src;
using LancerPlace_.NET_Demo.Src.Dtos.Applications.Freelancer;
using LancerPlace_.NET_Demo.Src.Services.Applications.Freelancer;

namespace LancerPlace_.Net_Demo.Endpoints.Applications.Freelancer;

public static class ApplicationsFreelancerEndpoints
{
    public static IEndpointRouteBuilder MapApplicationsFreelancerEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/applications/freelancer").RequireAuthorization("USER");

        group.MapPost("/createApplication", Create);

        return app;
    }

    private static async Task<IResult> Create(HttpContext ctx, ApplicationsFreelancerService service, CreateApplicationDtoReq body)
    {
        Guid userId = Guid.Parse(ctx.User.FindFirst("userId")!.Value);
        await service.Create(userId, body);
        return new CustomResult(true, 200, "پیشنهاد شما روی گهی با موفقیت ثبت شد.");
    }
}