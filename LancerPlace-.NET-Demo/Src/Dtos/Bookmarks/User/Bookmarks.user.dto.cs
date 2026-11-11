using LancerPlace.NET.Demo.Src.Enums;

namespace LancerPlace_.NET_Demo.Src.Dtos.Bookmarks.User;

public class BookmarkListItemDtoRes
{
    public class ProjectType
    {
        public class CategoryType
        {
            public Guid Id { get; set; } = null!;
            public string Title { get; set; } = null!;
            public string? ParentId { get; set; } = null!;
        }
        public Guid Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string PublishedAt { get; set; } = null!;
        public List<CategoryType> Categories { get; set; } = [];
        public long Budget { get; set; }
        public int DeadlineDays { get; set; }
    }
    public BookmarkTarget Target { get; set; }
    public ProjectType Project { get; set; } = null!;

}