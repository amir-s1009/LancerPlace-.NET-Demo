using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LancerPlace_.NET_Demo.Src.Models;
public class ProjectPromoSnapshot
{
    public Guid Id { get; set; }
    public ProjectPromoType Type { get; set; }
    [Range(0, long.MaxValue, ErrorMessage = "قیمت ارتقای پروژه نامعتبر است")]
    public long Price { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    public Guid ClientProfileId { get; set; }
    public ClientProfile ClientProfile { get; set; } = null!;
    public Transaction? Transaction { get; set; } = null!;
}