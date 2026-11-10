using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Message
{
    public Guid Id { get; set; }
    public string? Text { get; set; }
    public MessageType Type { get; set; }
    public Guid UserId { get; set; }
    public Guid ConversationId { get; set; }
    public bool IsSeen { get; set; }

    public User User { get; set; } = null!;
    public Conversation Conversation { get; set; } = null!;
}