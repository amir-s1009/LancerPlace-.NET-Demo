namespace LancerPlace_.NET_Demo.Src.Models;
public class RegisterPending
{
    public string Email { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public DateTime ExpiresAt { get; set; }
    public string Otp { get; set; } = null!;
    public bool IsVerified { get; set; }
}