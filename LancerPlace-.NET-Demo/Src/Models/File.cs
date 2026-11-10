namespace LancerPlace_.NET_Demo.Src.Models;
public class File
{
    public Guid Id { get; set; }
    public string StorageKey { get; set; } = null!;
    public string StorageUrl { get; set; } = null!;
    public string OriginalName { get; set; } = null!;
    public string MimeType { get; set; } = null!;
    public long SizeByte { get; set; }
    public DateTime CreatedAt { get; set; }
}
