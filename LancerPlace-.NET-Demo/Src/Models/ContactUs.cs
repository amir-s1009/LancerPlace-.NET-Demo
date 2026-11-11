using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LancerPlace_.NET_Demo.Src.Models;
public class ContactUs
{
    public Guid Id { get; set; }
    [EmailAddress(ErrorMessage = "آدرس ایمیل معتبر نیست")]
    public string Email { get; set; } = null!;
    [MaxLength(1000, ErrorMessage = "متن تماس با ما خیلی طولانی است")]
    public string Content { get; set; } = null!;
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
}