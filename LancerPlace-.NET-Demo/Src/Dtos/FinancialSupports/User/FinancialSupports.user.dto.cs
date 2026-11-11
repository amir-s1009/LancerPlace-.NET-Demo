namespace LancerPlace_.NET_Demo.Src.Dtos.FinancialSupports.User;

public class CreateFinancialSupportDtoReq
{
    public long Amount { get; set; }
    public string? Description { get; set; } = null!;
}
public class CreateFinancialSupportDtoRes
{
    public string PaymentUrl { get; set; } = null!;
}