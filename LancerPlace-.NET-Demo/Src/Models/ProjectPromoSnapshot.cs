using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class ProjectPromoSnapshot
{
    public Guid Id { get; set; }
    public ProjectPromoType Type { get; set; }
    public long Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public int ClientProfileId { get; set; }

    public ClientProfile ClientProfile { get; set; } = null!;
    public Transaction Transaction { get; set; } = null!;
}