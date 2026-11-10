using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class ProjectPromoStore
{
    public Guid Id { get; set; }
    public ProjectPromoType Type { get; set; }
    public long Price { get; set; }
    public int? PeriodDays { get; set; }
    public TargetProfile TargetProfile { get; set; }

}