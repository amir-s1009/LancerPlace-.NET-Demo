using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Bookmark
{
    public Guid Id { get; set; }
    public BookmarkTarget Target { get; set; }
    public Guid? ProjectId { get; set; }
    public Guid UserId { get; set; }

    public Project? Project { get; set; }
    public User User { get; set; } = null!;
}