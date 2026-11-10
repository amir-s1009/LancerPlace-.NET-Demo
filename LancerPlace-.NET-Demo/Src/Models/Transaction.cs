using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Transaction
{
    public Guid Id { get; set; }
    public string? GatewayReference { get; set; }
    public Guid UserId { get; set; }
    public long Amount { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? SuccessfulAt { get; set; }
    public DateTime? FailedAt { get; set; }
    public DateTime? ExpiredAt { get; set; }
    public Guid? TokenSnapshotId { get; set; }
    public Guid? FinancialSupportId { get; set; }
    public Guid? ProjectPromoSnapshotId { get; set; }
    public TransactionType Type { get; set; }
    public TransactionStatus Status { get; set; }

    public User User { get; set; } = null!;
    public TokenSnapshot? TokenSnapshot { get; set; }
    public FinancialSupport? FinancialSupport { get; set; }
    public ProjectPromoSnapshot? ProjectPromoSnapshot { get; set; }
}