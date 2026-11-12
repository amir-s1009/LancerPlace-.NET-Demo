using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using LancerPlace_.NET_Demo.Src.CustomExceptions;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Transaction
{
    public Guid Id { get; set; }
    public string? GatewayReference { get; set; }
    public Guid UserId { get; set; }
    [Range(0, long.MaxValue, ErrorMessage = "مبلغ تراکنش نامعتبر است")]
    public long Amount { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    public DateTime? SuccessfulAt { get; set; }
    public DateTime? FailedAt { get; set; }
    public DateTime? ExpiredAt { get; set; }
    public DateTime? RefundedAt { get; set; }
    public Guid? TokenSnapshotId { get; set; }
    public Guid? FinancialSupportId { get; set; }
    public Guid? ProjectPromoSnapshotId { get; set; }
    public TransactionType Type { get; set; }
    public TransactionStatus Status { get; set; }

    public User User { get; set; } = null!;
    public TokenSnapshot? TokenSnapshot { get; set; }
    public FinancialSupport? FinancialSupport { get; set; }
    public ProjectPromoSnapshot? ProjectPromoSnapshot { get; set; }

    public void SetToSuccessful()
    {
        if (Status == TransactionStatus.SUCCESSFUL) throw new DomainException("تراکنش قبلا موفق شده است.");
        Status = TransactionStatus.SUCCESSFUL;
        SuccessfulAt = new DateTime();
    }
    public void SetToFailed()
    {
        if (Status == TransactionStatus.FAILED) throw new DomainException("تراکنش قبلا ناموفق شده است.");
        Status = TransactionStatus.FAILED;
        FailedAt = new DateTime();
    }
    public void SetToExpired()
    {
        if (Status == TransactionStatus.EXPIRED) throw new DomainException("تراکنش قبلا منقضی شده است.");
        Status = TransactionStatus.EXPIRED;
        ExpiredAt = new DateTime();
    }
    public void SetToRefunded()
    {
        if (Status == TransactionStatus.REFUNDED) throw new DomainException("تراکنش قبلا عودت وجه شده است.");
        Status = TransactionStatus.REFUNDED;
        RefundedAt = new DateTime();
    }
}