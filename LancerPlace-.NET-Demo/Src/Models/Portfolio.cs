namespace LancerPlace_.NET_Demo.Src.Models;
public class Portfolio
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public bool IsPublic { get; set; }
    public Guid FreelancerProfileId { get; set; }

    public FreelancerProfile FreelancerProfile { get; set; } = null!;
    public ICollection<File> Files { get; set; } = [];
}