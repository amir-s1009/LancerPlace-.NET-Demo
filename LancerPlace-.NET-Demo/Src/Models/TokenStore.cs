using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class TokenStore
{
    public Guid Id { get; set; }
    public TargetProfile TargetProfile { get; set; }
    public int TokensCount { get; set; }
    public TokenPeriod Period { get; set; }
    public long Price { get; set; }
}