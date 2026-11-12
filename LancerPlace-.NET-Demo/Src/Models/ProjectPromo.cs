using System.ComponentModel.DataAnnotations.Schema;

namespace LancerPlace_.NET_Demo.Src.Models;
public class ProjectPromo
{
    public Guid Id { get; set; }
    public Guid ProjectId { get; set; }
    public ProjectPromoType Type { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    public DateTime? EndsAt { get; set; }

    public Project Project { get; set; } = null!;
    public ProjectPromoSnapshot ProjectPromoSnapshor { get; set; } = null!;
}