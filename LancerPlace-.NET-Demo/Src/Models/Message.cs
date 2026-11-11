using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Message
{
    public Guid Id { get; set; }
    [MaxLength(1000, ErrorMessage = "متن پیام خیلی طولانی است")]
    public string? Text { get; set; }
    public MessageType Type { get; set; }
    public Guid UserId { get; set; }
    public Guid ConversationId { get; set; }
    public bool IsSeen { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public User User { get; set; } = null!;
    public Conversation Conversation { get; set; } = null!;
}