using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Project
{
    public Guid Id { get; set; }
    [MaxLength(255, ErrorMessage = "عنوان پروژه خیلی طولانی است")]
    public string Title { get; set; } = null!;
    public ProjectStatus Status { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    [Range(0, long.MaxValue, ErrorMessage = "مبلغ بودجه نامعتبر است")]
    public long Budget { get; set; }
    [Range(0, int.MaxValue, ErrorMessage = "مدت زمان اجرا نامعتبر است")]
    public int DeadlineDays { get; set; }
    [MaxLength(2000, ErrorMessage = "متن توضیحات پروژه خیلی طولانی است")]
    public string Description { get; set; } = null!;
    public Guid CategoryId { get; set; }
    public Guid ClientProfileId { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public Category Category { get; set; } = null!;
    public ClientProfile ClientProfile { get; set; } = null!;


    public ICollection<Application> Applications { get; set; } = new List<Application>();
    public ICollection<Spam> Spams { get; set; } = new List<Spam>();
    public ICollection<ProjectPromo> Promotions { get; set; } = new List<ProjectPromo>();
    public ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();
}
