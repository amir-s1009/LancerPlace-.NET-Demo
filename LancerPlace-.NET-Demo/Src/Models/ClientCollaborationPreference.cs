namespace LancerPlace_.NET_Demo.Src.Models;
public class ClientCollaborationPreference
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public Guid ClientProfileId { get; set; }

    public ClientProfile ClientProfile { get; set; } = null!;
}