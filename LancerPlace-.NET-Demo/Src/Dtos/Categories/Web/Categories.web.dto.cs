namespace LancerPlace_.NET_Demo.Src.Dtos.Categories.Web;

public class CategoryListItemDtoRes
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string? ParentId { get; set; } = null!;
}