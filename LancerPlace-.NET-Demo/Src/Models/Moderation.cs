

namespace LancerPlace_.NET_Demo.Src.Models;
public class Moderation
{
    public Guid Id { get; set; }
    public ModerationType Type { get; set; }
    public TargetProfile? TargetProfile { get; set; }
    public Guid? FreelancerProfileId { get; set; }
    public Guid? ClientProfileId { get; set; }
    public string Message { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public DateTime? EndsAt { get; set; }
    public ModerationCause Cause { get; set; }
    public Guid? SpamId { get; set; }

    public FreelancerProfile? FreelancerProfile { get; set; }
    public ClientProfile? ClientProfile { get; set; }
    public Spam? Spam { get; set; }
}