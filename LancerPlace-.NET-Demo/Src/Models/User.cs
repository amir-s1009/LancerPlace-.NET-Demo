using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Models;
public class User
{
    public Guid Id { get; set; }
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Role Role { get; set; }
    public DateTime JoinedAt { get; set; }
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
}