using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Token
{
    public Guid Id { get; set; }
    public int Remaining { get; set; }
    public DateTime EndsAt { get; set; }
    public Guid? ClientProfileId { get; set; }
    public Guid? FreelancerProfileId { get; set; }
    public TargetProfile TargetProfile { get; set; }
    public bool IsActive { get; set; }
    public bool? IsDefault { get; set; }
    public DateTime? ActivatedAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid TokenSnapshotId { get; set; }

    public ClientProfile? ClientProfile { get; set; }
    public FreelancerProfile? FreelancerProfile { get; set; }
    public TokenSnapshot? TokenSnapshot { get; set; }
}