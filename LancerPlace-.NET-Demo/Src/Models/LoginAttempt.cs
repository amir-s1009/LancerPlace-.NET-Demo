using System.ComponentModel.DataAnnotations.Schema;

namespace LancerPlace_.NET_Demo.Src.Models;
public class LoginAttempt
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    public bool IsSuccessful { get; set; }

    public User User { get; set; } = null!;
}