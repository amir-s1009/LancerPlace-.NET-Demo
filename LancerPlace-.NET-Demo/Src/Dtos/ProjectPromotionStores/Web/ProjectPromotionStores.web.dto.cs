

namespace LancerPlace_.NET_Demo.Src.Dtos.ProjectPromotionStores.Web;

public class ProjectPromotionStoreListItemDtoRes
{
    public Guid Id { get; set; } = null!;
    public ProjectPromoType Type { get; set; }
    public long Price { get; set; }
    public int? PeriodDays { get; set; }
}