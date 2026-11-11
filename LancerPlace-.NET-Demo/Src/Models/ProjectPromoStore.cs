using System.ComponentModel.DataAnnotations;
using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class ProjectPromoStore
{
    public Guid Id { get; set; }
    public ProjectPromoType Type { get; set; }
    [Range(0, long.MaxValue, ErrorMessage = "قیمت ارتقای پروژه نامعتبر است")]
    public long Price { get; set; }
    [Range(0, int.MaxValue, ErrorMessage = "مدت زمان فعالیت نامعتبر است")]
    public int? PeriodDays { get; set; }
    public TargetProfile TargetProfile { get; set; }

}