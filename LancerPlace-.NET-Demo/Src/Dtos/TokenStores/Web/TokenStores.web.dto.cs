using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Dtos.TokenStores.Web;

public class TokenStoreListItemDtoRes
{
    public string Id { get; set; } = null!;
    public TokenPeriod Period { get; set; }
    public long Price { get; set; }
    public TargetProfile TargetProfile { get; set; }
    public int TokensCount { get; set; }
}
public class TokenStoreDetailDtoRes
{
    public string Id { get; set; } = null!;
    public TokenPeriod Period { get; set; }
    public long Price { get; set; }
    public TargetProfile TargetProfile { get; set; }
    public int TokensCount { get; set; }
}