

namespace LancerPlace_.NET_Demo.Src.Dtos.Projects.Web;

public class ProjectListItemDtoRes
{
    public class CategoryType
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public Guid? ParentId { get; set; }

    }
    public class ClientType
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? AvatarUrl { get; set; } = null!;
    }
    public class PromotionType
    {
        public ProjectPromoType Type { get; set; }
    }
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public List<CategoryType> Categories { get; set; } = [];
    public ProjectStatus Status { get; set; }
    public bool IsBookmarked { get; set; }
    public long Budget { get; set; }
    public ClientType Client { get; set; } = null!;
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
        public Guid? ParentId { get; set; }

    }
    public class ClientType
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? AvatarUrl { get; set; } = null!;
    }


    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public List<CategoryType> Categories { get; set; } = [];
    public ProjectStatus Status { get; set; }
    public long Budget { get; set; }
    public int DeadlineDays { get; set; }
    public ClientType Client { get; set; } = null!;
    public string PublishedAt { get; set; } = null!;
    public string? UpdatedAt { get; set; } = null!;
    public string Description { get; set; } = null!;
}