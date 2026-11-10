using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Conversation
{
    public Guid Id { get; set; }
    public Guid ApplicationId { get; set; }
    public DateTime CreatedAt { get; set; }
    public ConversationStatus Status { get; set; }

    public Application Application { get; set; } = null!;

    public ICollection<Message> Messages { get; set; } = [];
    public ICollection<Spam> Spams { get; set; } = [];
}