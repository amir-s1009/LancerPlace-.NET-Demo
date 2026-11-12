using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LancerPlace_.NET_Demo.Src.Models;
public class Spam
{
    public Guid Id { get; set; }
    public SpamType Type { get; set; }
    public SpamStatus Status { get; set; }
    public Guid UserId { get; set; }
    public Guid? ProjectId { get; set; }
    public Guid? ConversationId { get; set; }
    public Guid? ApplicationId { get; set; }
    public Guid? EndorsementId { get; set; }
    [MaxLength(1000, ErrorMessage = "متن گزارش تخلف خیلی طولانی است")]
    public string Message { get; set; } = null!;
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }

    public User User { get; set; } = null!;
    public Project? Project { get; set; }
    public Conversation? Conversation { get; set; }
    public Application? Application { get; set; }
    public Endorsement? Endorsement { get; set; }
    public ICollection<Moderation> Moderations { get; set; } = [];

    public void Resolve()
    {
        if (Status != SpamStatus.PENDING) throw new DomainException("گزراش تخلف قبلا تعیین تکلیف شده است.");
        Status = SpamStatus.NO_ACTION;
    }
    public void Moderate()
    {
        if (Status != SpamStatus.PENDING) throw new DomainException("گزراش تخلف قبلا تعیین تکلیف شده است.");
        Status = SpamStatus.MODERATED;
    }
}