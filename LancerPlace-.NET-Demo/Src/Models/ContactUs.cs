namespace LancerPlace_.NET_Demo.Src.Models;
public class ContactUs
{
    public Guid Id { get; set; }
    public string Email { get; set; } = null!;
    public string Content { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
}