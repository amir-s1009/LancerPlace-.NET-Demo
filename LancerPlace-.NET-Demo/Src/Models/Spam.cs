using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Spam
{
    public Guid Id { get; set; }
    public SpamType Type { get; set; }
    public SpamStatus Status { get; set; }
    public Guid UserId { get; set; }
    public Guid? ProjectId { get; set; }
    public Guid? ConversationId { get; set; }
    public Guid? ApplicationId { get; set; }
    public Guid? EndorsementId { get; set; }
    public string Message { get; set; } = null!;
    public DateTime CreatedAt { get; set; }

    public User User { get; set; } = null!;
    public Project? Project { get; set; }
    public Conversation? Conversation { get; set; }
    public Application? Application { get; set; }
    public Endorsement? Endorsement { get; set; }
    public ICollection<Moderation>? Moderations { get; set; }
}