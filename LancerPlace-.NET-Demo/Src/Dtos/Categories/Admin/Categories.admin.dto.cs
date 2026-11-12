namespace LancerPlace_.NET_Demo.Src.Dtos.Categories.Admin;

public class CreateCategoryDtoReq
{
    public string Title { get; set; } = null!;
    public Guid? ParentId { get; set; }
}

public class UpdateCategoryDtoReq
{
    public string Title { get; set; } = null!;
}
