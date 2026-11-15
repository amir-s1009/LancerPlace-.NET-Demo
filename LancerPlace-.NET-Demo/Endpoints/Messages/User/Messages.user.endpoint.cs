using LancerPlace_.NET_Demo.Attributes;
using LancerPlace_.NET_Demo.Src;
using LancerPlace_.NET_Demo.Src.Dtos.Messages.User;
using LancerPlace_.NET_Demo.Src.Services.Messages;

namespace LancerPlace_.NET_Demo.Endpoints.Messages.User;

public static class MessagesUserEndpoints
{
    public static IEndpointRouteBuilder MapMessagesUserEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/messages/user")
        .WithMetadata(new PreventConcurrentRequestsAttribute())
        .RequireAuthorization("USER");

        group.MapPost("/createMessage", Create);
        return app;
    }

    private static async Task<IResult> Create(HttpContext ctx, CreateMessageDtoReq body, MessagesUserService service)
    {
        Guid userId = Guid.Parse(ctx.User.FindFirst("userId")!.Value);
        await service.Create(userId, body);
        return new CustomResult(true, 200, "پیام شما با موفقیت ارسال شد.");
    }
}