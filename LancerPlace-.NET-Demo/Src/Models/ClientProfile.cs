namespace LancerPlace_.NET_Demo.Src.Models;
public class ClientProfile
{
    public Guid Id { get; set; }
    public string? Bio { get; set; }
    public Guid UserId { get; set; }

    public User User { get; set; } = null!;

    public ICollection<Endorsement> GivenEndorsements { get; set; } = [];
    public ICollection<Token> Tokens { get; set; } = [];
    public ICollection<TokenSnapshot> TokenSnapshots { get; set; } = [];
    public ICollection<ProjectPromoSnapshot> ProjectPromoSnapshots { get; set; } = [];
    public ICollection<ClientCollaborationPreference> CollaborationPreferences { get; set; } = [];
    public ICollection<Moderation> Moderations { get; set; } = [];
    public ICollection<Project> Projects { get; set; } = [];
}
