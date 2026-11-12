

namespace LancerPlace_.NET_Demo.Src.Dtos.Transactions.User;

public class TransactionListItemDtoRes
{
    public Guid Id { get; set; } = null!;
    public string Type { get; set; } = null!;
    public long Amount { get; set; }
    public TransactionStatus Status { get; set; }
    public string CreatedAt { get; set; } = null!;
    public string? SuccessfulAt { get; set; } = null!;
    public string? FailedAt { get; set; } = null!;
    public string? ExpiredAt { get; set; } = null!;
    public string? RefundedAt { get; set; } = null!;
}

public class VerifyPaymentDtoReq
{
    public string GatewayReference { get; set; } = null!;
}
public class VerifyPaymentDtoRes
{
    public class TransactionType
    {
        public Guid Id { get; set; } = null!;
        public TransactionStatus Status { get; set; }
        public string Type { get; set; } = null!;
        public long Amount { get; set; }
        public string? GatewayReference { get; set; } = null!;
        public string CreatedAt { get; set; } = null!;
        public string? SuccessfulAt { get; set; } = null!;
        public string? FailedAt { get; set; } = null!;
        public string? ExpiredAt { get; set; } = null!;
        public string? RefundedAt { get; set; } = null!;
    }
    public TransactionType Transaction { get; set; } = null!;
}

public class TransactionsInformaticsDtoRes
{
    public class CountType
    {
        public int Total { get; set; }
        public int Pending { get; set; }
        public int Successful { get; set; }
        public int Failed { get; set; }
        public int Refunded { get; set; }
        public int Expired { get; set; }
    }
    public CountType Count { get; set; } = null!;
}