using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Token
{
    public Guid Id { get; set; }
    [Range(0, int.MaxValue, ErrorMessage = "باقیمانده بسته اعتباری نامعتبر است")]
    public int Remaining { get; set; }
    public DateTime EndsAt { get; set; }
    public Guid? ClientProfileId { get; set; }
    public Guid? FreelancerProfileId { get; set; }
    public TargetProfile TargetProfile { get; set; }
    public bool IsActive { get; set; }
    public bool? IsDefault { get; set; }
    public DateTime? ActivatedAt { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    public Guid? TokenSnapshotId { get; set; }

    public ClientProfile? ClientProfile { get; set; }
    public FreelancerProfile? FreelancerProfile { get; set; }
    public TokenSnapshot? TokenSnapshot { get; set; } = null!;

    public bool IsExpired()
    {
        return EndsAt < new DateTime();
    }

    public void Activate()
    {
        if (IsActive) throw new DomainException("توکن قبلا فعال شده است.");
        if (IsExpired()) throw new DomainException("توکن منقضی شده و امکان فعالسازی آن وجود ندارد.");
        IsActive = true;
        ActivatedAt = new DateTime();
    }
    public void DeActivate()
    {
        if (!IsActive) throw new DomainException("توکن قبلا غیرفعال شده است.");
        IsActive = false;
    }
    public void Use()
    {
        if (!IsActive) throw new DomainException("توکن هنوز فعال نشده و امکان استفاده از آن وجود ندارد!");
        if (IsExpired()) throw new DomainException("توکن منقضی شده قابل استفاده نیست.");
        if (Remaining < 1) throw new DomainException("اعتبار توکن 0 بوده و قابل استفاده نیست.");
        Remaining--;
    }
}