using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Project
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public ProjectStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    public long Budget { get; set; }
    public int DeadlineDays { get; set; }
    public string Description { get; set; } = null!;
    public Guid CategoryId { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public Category Category { get; set; } = null!;

    public ICollection<Application> Applications { get; set; } = new List<Application>();
    public ICollection<Spam> Spams { get; set; } = new List<Spam>();
    public ICollection<Endorsement> Endorsements { get; set; } = new List<Endorsement>();
    public ICollection<ProjectPromo> Promotions { get; set; } = new List<ProjectPromo>();
    public ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();
}
