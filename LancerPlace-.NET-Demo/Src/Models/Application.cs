using System.ComponentModel.DataAnnotations;
using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Application
{
    public Guid Id { get; set; }
    [Range(0, long.MaxValue)]
    public long SuggestionAmount { get; set; }
    [Range(0, int.MaxValue)]
    public int DeadlineDays { get; set; }
    public ApplicationStatus Status { get; set; }
    [MaxLength(1000, ErrorMessage = "متن توضیح پیشنهاد خیلی طولانی است")]
    public string Coverletter { get; set; } = null!;
    public Guid ProjectId { get; set; }
    public Guid FreelancerProfileId { get; set; }
    public Guid? ConversationId { get; set; } = null!;
    public DateTime CreatedAt { get; set; }

    public Project Project { get; set; } = null!;
    public FreelancerProfile FreelancerProfile { get; set; } = null!;
    public Conversation? Conversation { get; set; } = null!;
    public ICollection<Spam> Spams { get; set; } = [];
    public Endorsement? Edorsement { get; set; } = null!;
}