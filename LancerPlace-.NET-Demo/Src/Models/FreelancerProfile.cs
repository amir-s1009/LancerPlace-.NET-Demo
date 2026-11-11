using System.ComponentModel.DataAnnotations;

namespace LancerPlace_.NET_Demo.Src.Models;
public class FreelancerProfile
{
    public Guid Id { get; set; }
    [MaxLength(1000, ErrorMessage = "متن درباره من خیلی طولانی است")]
    public string? Bio { get; set; }
    public Guid UserId { get; set; }

    public User User { get; set; } = null!;

    public ICollection<FreelancerSkill> Skills { get; set; } = [];
    public ICollection<Portfolio> Portfolios { get; set; } = [];
    public ICollection<CV> CVs { get; set; } = [];
    public ICollection<Token> Tokens { get; set; } = [];
    public ICollection<TokenSnapshot> TokenSnapshots { get; set; } = [];
    public ICollection<Endorsement> ReceivedEndorsements { get; set; } = [];
    public ICollection<Moderation> Moderations { get; set; } = [];
    public ICollection<Application> Applications { get; set; } = [];

}