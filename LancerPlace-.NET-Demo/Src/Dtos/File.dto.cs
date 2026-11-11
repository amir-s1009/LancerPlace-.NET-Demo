namespace LancerPlace_.NET_Demo.Src.Dtos.File;

public class FileDtoReq
{
    public Guid? Id { get; set; } = null!;
    public string Key { get; set; } = null!;
    public string Url { get; set; } = null!;
    public string MimeType { get; set; } = null!;
    public string SizeByte { get; set; } = null!;
    public string OriginalName { get; set; } = null!;
}
public class FileDtoRes
{
    public Guid Id { get; set; } = null!;
    public string Key { get; set; } = null!;
    public string Url { get; set; } = null!;
    public string MimeType { get; set; } = null!;
    public string SizeByte { get; set; } = null!;
    public string OriginalName { get; set; } = null!;
}