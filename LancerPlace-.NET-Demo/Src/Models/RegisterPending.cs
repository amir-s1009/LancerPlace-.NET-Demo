using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LancerPlace_.NET_Demo.Src.Models;

[Index(nameof(Email), IsUnique = true)]
public class RegisterPending
{
    [EmailAddress(ErrorMessage = "طول otp نامعتبر است")]
    public string Email { get; set; } = null!;
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    private DateTime ExpiresAt { get; set; }
    [StringLength(5, ErrorMessage = "طول otp نامعتبر است")]
    private string Otp { get; set; } = null!;
    public bool IsVerified { get; set; }

    public bool IsExpired()
    {
        return ExpiresAt < new DateTime();
    }
    public void Reset(string otp, DateTime expiresAt)
    {
        if (!IsExpired()) throw new DomainException("تاریخ انقضا هنوز فرا نرسیده است.");
        ExpiresAt = expiresAt;
        Otp = otp;
    }

    public string getOtp()
    {
        return Otp;
    }
}