using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Portfolio
{
    public Guid Id { get; set; }
    [MaxLength(255, ErrorMessage = "عنوان نمونه کار خیلی طولانی است")]
    public string Title { get; set; } = null!;
    [MaxLength(1000, ErrorMessage = "توضیح نمونه کار خیلی طولانی است")]
    public string Description { get; set; } = null!;
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    public bool IsPublic { get; set; }
    public Guid FreelancerProfileId { get; set; }

    public FreelancerProfile FreelancerProfile { get; set; } = null!;
    public ICollection<File> Files { get; set; } = [];
}