namespace LancerPlace_.NET_Demo.Src.Models;
public class FreelancerSkill
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public Guid FreelancerProfileId { get; set; }

    public FreelancerProfile FreelancerProfile { get; set; } = null!;
}