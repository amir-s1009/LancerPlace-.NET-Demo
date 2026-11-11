using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Dtos.ProjectPromotions.Client;

public class ActiveProjectPromotionListItemDtoRes
{
    public string Id { get; set; } = null!;
    public ProjectPromoType Type { get; set; }
}