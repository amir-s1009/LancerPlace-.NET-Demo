using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Endorsement
{
    public Guid Id { get; set; }
    [MaxLength(1000, ErrorMessage = "متن توصیه نامه خیلی طولانی است")]
    public string Description { get; set; } = null!;
    public Guid ClientProfileId { get; set; }
    public Guid FreelancerProfileId { get; set; }
    public Guid ApplicationId { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    public EndorsementStatus Status { get; set; }

    public ClientProfile ClientProfile { get; set; } = null!;
    public FreelancerProfile FreelancerProfile { get; set; } = null!;
    public Application Application { get; set; } = null!;

    public ICollection<Spam> Spams { get; set; } = [];
}