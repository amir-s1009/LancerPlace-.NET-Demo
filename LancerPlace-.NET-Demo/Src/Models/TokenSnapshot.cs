using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class TokenSnapshot
{
    public Guid Id { get; set; }
    [Range(0, int.MaxValue, ErrorMessage = "تعداد توکن ها نامعتبر است")]
    public int TokensCount { get; set; }
    public TokenPeriod Period { get; set; }
    [Range(0, long.MaxValue, ErrorMessage = "قیمت توکن نامعتبر است")]
    public long Price { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    public Guid? FreelancerProfileId { get; set; }
    public Guid? ClientProfileId { get; set; }
    public TargetProfile? TargetProfile { get; set; }
    public Guid? TokenId { get; set; }

    public FreelancerProfile? FreelancerProfile { get; set; }
    public ClientProfile? ClientProfile { get; set; }
    public Token? Token { get; set; }
    public Transaction? Transaction { get; set; }
}