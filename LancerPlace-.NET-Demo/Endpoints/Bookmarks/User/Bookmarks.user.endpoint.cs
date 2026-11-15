using LancerPlace_.NET_Demo.Attributes;
using LancerPlace_.NET_Demo.Src;
using LancerPlace_.NET_Demo.Src.Dtos.Bookmarks.User;
using LancerPlace_.NET_Demo.Src.Services.Bookmarks.User;
using Microsoft.AspNetCore.Mvc;

namespace LancerPlace_.NET_Demo.Endpoints.Bookmarks.User;

public static class BookmarksUserEndpoints
{
    public static IEndpointRouteBuilder MapBookmarksUserEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/bookmarks/user")
        .WithMetadata(new PreventConcurrentRequestsAttribute())
        .RequireAuthorization("USER");

        group.MapGet("/toggleBookmark/{target}/{targetId}", Toggle);
        group.MapGet("/getAllBookmarks", GetAll);

        return app;
    }

    private static async Task<IResult> Toggle(BookmarksUserService service, HttpContext ctx, BookmarkTarget target, Guid targetId)
    {
        Guid userId = Guid.Parse(ctx.User.FindFirst("userId")!.Value);
        await service.ToggleBookmark(userId, target, targetId);
        return new CustomResult(true, 200, "نشان شما با موفقیت معکوس شد.");
    }
    private static async Task<IResult> GetAll(BookmarksUserService service, HttpContext ctx, [FromQuery] BookmarkTarget? target)
    {
        Guid userId = Guid.Parse(ctx.User.FindFirst("userId")!.Value);
        var data = await service.GetAllBookmarks(userId, target);
        return new CustomResult<List<BookmarkListItemDtoRes>>(true, 200, "لیست نشان های شما ارسال شد.", data, null);
    }
}