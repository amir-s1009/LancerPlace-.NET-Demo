using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Dtos.Tokens.Freelancer;

public class ActiveTokenDtoRes
{
    public string Id { get; set; } = null!;
    public int Remaining { get; set; }
    public int TokensCount { get; set; }
    public string EndsAt { get; set; } = null!;
    public TokenPeriod Period { get; set; }
}
public class TokenListItemDtoRes
{
    public string Id { get; set; } = null!;
    public int Remaining { get; set; }
    public string EndsAt { get; set; } = null!;
    public TokenPeriod Period { get; set; }
    public bool IsActive { get; set; }
    public bool IsDefault { get; set; }
}