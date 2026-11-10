using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Endorsement
{
    public Guid Id { get; set; }
    public string Description { get; set; } = null!;
    public Guid ClientProfileId { get; set; }
    public Guid FreelancerProfileId { get; set; }
    public Guid ApplicationId { get; set; }
    public DateTime CreatedAt { get; set; }
    public EndorsementStatus Status { get; set; }

    public ClientProfile ClientProfile { get; set; } = null!;
    public FreelancerProfile FreelancerProfile { get; set; } = null!;
    public Application Application { get; set; } = null!;

    public ICollection<Spam> Spams { get; set; } = [];
}