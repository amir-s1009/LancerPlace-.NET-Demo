namespace LancerPlace_.NET_Demo.Src.Dtos.Categories.Admin;

public class CreateCategoryDtoReq
{
    public string Title { get; set; } = null!;
    public string? ParentId { get; set; } = null!;
}

public class UpdateCategoryDtoReq
{
    public string Title { get; set; } = null!;
}
