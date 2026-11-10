namespace LancerPlace_.NET_Demo.Src.Models;
public class CV
{
    public Guid Id { get; set; }
    public Guid FreelancerProfileId { get; set; }
    public bool IsPublic { get; set; }

    public FreelancerProfile FreelancerProfile { get; set; } = null!;
}