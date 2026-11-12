using LancerPlace_.NET_Demo.Src.Dtos.File;

namespace LancerPlace_.NET_Demo.Src.Dtos.ClientProfiles.Web;

public class ClientProfileInfoDtoRes
{
    public class UserInfoType
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? AvatarUrl { get; set; } = null!;
    }
    public class PreferenceType
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
    }
    public class ProjectType
    {
        public class CategoryType
        {
            public Guid Id { get; set; }
            public string Title { get; set; } = null!;
            public string? ParentId { get; set; } = null!;

        }
        public class CollaboratedApplicationType
        {
            public class FreelancerProfileType
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
            public long Budget { get; set; }
            public FreelancerProfileType FreelancerProfile { get; set; } = null!;

        }
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public List<CategoryType> Categories { get; set; } = [];
        public long Budget { get; set; }
        public CollaboratedApplicationType CollaboratedApplication { get; set; } = null!;
    }
    public UserInfoType UserInfo { get; set; } = null!;
    public string? Bio { get; set; } = null!;
    public List<PreferenceType> Preferences { get; set; } = [];
    public List<ProjectType> Projects { get; set; } = [];
}