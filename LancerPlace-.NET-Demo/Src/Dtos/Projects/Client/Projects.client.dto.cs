

namespace LancerPlace_.NET_Demo.Src.Dtos.Projects.Client;

public class CreateProjectDtoReq
{
    public string Title { get; set; } = null!;
    public string CategoryId { get; set; } = null!;
    public string Description { get; set; } = null!;
    public long Budget { get; set; }
    public int DeadlineDays { get; set; }
}

public class UpdateProjectDtoReq
{
    public string Title { get; set; } = null!;
    public string CategoryId { get; set; } = null!;
    public string Description { get; set; } = null!;
    public long Budget { get; set; }
    public int DeadlineDays { get; set; }
}


public class ProjectInformaticsDtoRes
{
    public class CountType
    {
        public int Total { get; set; }
        public int Hiring { get; set; }
        public int Spam { get; set; }
        public int Reviewing { get; set; }
        public int Running { get; set; }
        public int Completed { get; set; }
        public int Canceled { get; set; }
    }

    public CountType Count { get; set; } = null!;
}

public class ProjectListItemDtoRes
{
    public class CategoryType
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? ParentId { get; set; } = null!;

    }
    public class PromotionType
    {
        public ProjectPromoType Type { get; set; }
        public string? EndsAt { get; set; }
    }
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public List<CategoryType> Categories { get; set; } = [];
    public ProjectStatus Status { get; set; }
    public long Budget { get; set; }
    public string PublishedAt { get; set; } = null!;
    public string? UpdatedAt { get; set; } = null!;
    public int ApplicationsCount { get; set; }
    public string Description { get; set; } = null!;
    public List<PromotionType> Promotions { get; set; } = [];
}

public class ProjectDetailDtoRes
{
    public class CategoryType
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? ParentId { get; set; } = null!;

    }
    public class PromotionType
    {
        public ProjectPromoType Type { get; set; }
        public string? EndsAt { get; set; }
    }

    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public List<CategoryType> Categories { get; set; } = [];
    public ProjectStatus Status { get; set; }
    public long Budget { get; set; }
    public int DeadlineDays { get; set; }
    public string PublishedAt { get; set; } = null!;
    public string? UpdatedAt { get; set; } = null!;
    public string Description { get; set; } = null!;
    public List<PromotionType> Promotions { get; set; } = null!;
}