using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class TokenSnapshot
{
    public Guid Id { get; set; }
    public int TokensCount { get; set; }
    public int Period { get; set; }
    public long Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? FreelancerProfileId { get; set; }
    public Guid? ClientProfileId { get; set; }
    public TargetProfile? TargetProfile { get; set; }
    public Guid? TokenId { get; set; }

    public FreelancerProfile? FreelancerProfile { get; set; }
    public ClientProfile? ClientProfile { get; set; }
    public Token? Token { get; set; }

    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}