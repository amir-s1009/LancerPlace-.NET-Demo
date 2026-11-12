using System.ComponentModel.DataAnnotations.Schema;


namespace LancerPlace_.NET_Demo.Src.Models;
public class Log
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public TargetProfile TargetProfile { get; set; }
    public LogType Type { get; set; }
    public Guid EntityId { get; set; }
    public string Message { get; set; } = null!;
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }

    public User User { get; set; } = null!;
}