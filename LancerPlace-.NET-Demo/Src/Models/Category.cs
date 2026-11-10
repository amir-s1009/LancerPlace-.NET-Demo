namespace LancerPlace_.NET_Demo.Src.Models;
public class Category
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public Guid? ParentId { get; set; }

    public Category? Parent { get; set; }
    public ICollection<Category> Children { get; set; } = [];
    public ICollection<Project> Projects { get; set; } = [];
}