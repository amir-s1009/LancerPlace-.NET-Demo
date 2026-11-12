using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using LancerPlace_.NET_Demo.Src.CustomExceptions;

namespace LancerPlace_.NET_Demo.Src.Models;
public class User
{
    public Guid Id { get; set; }
    [EmailAddress(ErrorMessage = "آدرس ایمیل نامعتبر است")]
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    [MaxLength(50, ErrorMessage = "نام خیلی طولانی است")]
    public string FirstName { get; set; } = null!;
    [MaxLength(50, ErrorMessage = "نام خانوادکی خیلی طولانی است")]
    public string LastName { get; set; } = null!;
    public Role Role { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime JoinedAt { get; set; }
    [RegularExpression(@"^09\d{9}$", ErrorMessage = "شماره موبایل نامعتبر است")]
    public string? PhoneNumber { get; set; }
    public bool IsLimited { get; set; }
    public DateTime? LimitedUntil { get; set; }
    public TargetProfile LastUsedProfile { get; set; }

    public FreelancerProfile FreelancerProfile { get; set; } = null!;
    public ClientProfile ClientProfile { get; set; } = null!;
    public ICollection<Message> Messages { get; set; } = [];
    public ICollection<Spam> Spams { get; set; } = [];
    public ICollection<Transaction> Transactions { get; set; } = [];
    public ICollection<FinancialSupport> FinancialSupports { get; set; } = [];
    public ICollection<Bookmark> Bookmarks { get; set; } = [];
    public ICollection<LoginAttempt> LoginAttempts { get; set; } = [];
    public ICollection<Log> Logs { get; set; } = [];

    public void Limit(DateTime until)
    {
        if (IsLimited) throw new DomainException("کاربر در حال حاضر محدود میباشد.");
        IsLimited = true;
        LimitedUntil = until;
    }
}