using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Dtos.TokenStores.Admin;

public class CreateTokenStoreDtoReq
{
    public TokenPeriod Period { get; set; }
    public long Price { get; set; }
    public TargetProfile TargetProfile { get; set; }
    public int TokensCount { get; set; }
}
public class UpdateTokenStoreDtoReq
{
    public long Price { get; set; }
    public int TokensCount { get; set; }
}