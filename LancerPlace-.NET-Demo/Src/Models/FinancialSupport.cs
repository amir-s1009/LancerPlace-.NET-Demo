using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LancerPlace_.NET_Demo.Src.Models;
public class FinancialSupport
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    [MaxLength(1000, ErrorMessage = "متن توضیح خیلی طولانی است")]
    public string? Description { get; set; } = null!;
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }

    public User User { get; set; } = null!;

    public ICollection<Transaction> Transactions { get; set; } = [];
}