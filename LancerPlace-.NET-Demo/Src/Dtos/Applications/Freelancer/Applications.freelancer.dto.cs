
using LancerPlace_.NET_Demo.Src.Dtos.File;

namespace LancerPlace_.NET_Demo.Src.Dtos.Applications.Freelancer;

public class ApplicationListItemDtoRes
{
    public class ProjectType
    {
        public class CategoryType
        {
            public Guid Id { get; set; }
            public string Title { get; set; } = null!;
            public Guid? ParentId { get; set; }
        }
        public class ClientProfileType
        {
            public class UserInfoType
            {
                public string FirstName { get; set; } = null!;
                public string LastName { get; set; } = null!;
                public FileDtoRes? Avatar { get; set; } = null!;
            }
            public Guid Id { get; set; }
            public UserInfoType UserInfo { get; set; } = null!;
        }
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public List<CategoryType> Categories { get; set; } = [];
        public long Budget { get; set; }
        public string publishedAt { get; set; } = null!;
        public int ApplicationsCount { get; set; }
        public ClientProfileType ClientProfile { get; set; } = null!;
    }
    public Guid Id { get; set; }
    public long Budget { get; set; }
    public ApplicationStatus Status { get; set; }
    public string Description { get; set; } = null!;
    public ProjectType Project { get; set; } = null!;
}

public class ApplicationDetailDtoRes
{
    public Guid Id { get; set; }
    public ApplicationStatus Status { get; set; }
    public string Description { get; set; } = null!;
    public long Budget { get; set; }
    public int DeadlineDays { get; set; }
    public string CreatedAt { get; set; } = null!;
}

public class CreateApplicationDtoReq
{
    public class ApplicationType
    {
        public long Budget { get; set; }
        public int DeadlineDays { get; set; }
        public string Description { get; set; } = null!;
    }
    public string ProjectId { get; set; } = null!;
    public ApplicationType Application { get; set; } = null!;
}

public class ApplicationsInformaticsDtoRes
{
    public class CountType
    {
        public int Total { get; set; }
        public int Pending { get; set; }
        public int Read { get; set; }
        public int Collaborating { get; set; }
        public int Rejected { get; set; }
        public int Done { get; set; }
        public int Spam { get; set; }
    }
    public CountType Count { get; set; } = null!;
}