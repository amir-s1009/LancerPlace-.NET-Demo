using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Dtos.ProjectPromotionStores.Admin;

public class CreateProjectPromoStoreDtoReq
{
    public ProjectPromoType Type { get; set; }
    public long Price { get; set; }
    public int? PeriodDays { get; set; }
}
public class UpdateProjectPromoStoreDtoReq
{
    public long Price { get; set; }
    public int? PeriodDays { get; set; }
}