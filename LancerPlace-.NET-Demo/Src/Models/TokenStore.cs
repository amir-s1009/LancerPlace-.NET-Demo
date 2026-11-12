using System.ComponentModel.DataAnnotations;

namespace LancerPlace_.NET_Demo.Src.Models;
public class TokenStore
{
    public Guid Id { get; set; }
    public TargetProfile TargetProfile { get; set; }
    [Range(0, int.MaxValue, ErrorMessage = "تعداد توکن ها نامعتبر است")]
    public int TokensCount { get; set; }
    public TokenPeriod Period { get; set; }
    [Range(0, long.MaxValue, ErrorMessage = "قیمت توکن نامعتبر است")]
    public long Price { get; set; }
}