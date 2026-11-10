using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Application
{
    public Guid Id { get; set; }
    public long SuggestionAmount { get; set; }
    public int DeadlineDays { get; set; }
    public ApplicationStatus Status { get; set; }
    public string Coverletter { get; set; } = null!;
    public Guid ProjectId { get; set; }
    public Guid FreelancerProfileId { get; set; }
    public Guid? ConversationId { get; set; } = null!;
    public DateTime CreatedAt { get; set; }

    public Project Project { get; set; } = null!;
    public FreelancerProfile FreelancerProfile { get; set; } = null!;
    public Conversation? Conversation { get; set; } = null!;
    public ICollection<Spam> Spams { get; set; } = [];
}