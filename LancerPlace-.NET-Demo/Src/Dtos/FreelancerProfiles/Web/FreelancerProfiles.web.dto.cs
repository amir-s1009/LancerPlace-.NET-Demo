using LancerPlace_.NET_Demo.Src.Dtos.File;

namespace LancerPlace_.NET_Demo.Src.Dtos.FrelancerProfiles.Web;

public class FreelancerProfileInfoDtoRes
{
    public class SkillType
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
    public class CVType
    {
        public string Url { get; set; } = null!;
    }
    public class UserInfoType
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? AvatarUrl { get; set; } = null!;
    }
    public class PortfolioType
    {
        public string Id { get; set; } = null!;
        public string? PosterUrl { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CreatedAt { get; set; } = null!;
    }
    public class EndorsementType
    {
        public class ProjectType
        {
            public class ClientProfileType
            {
                public class UserInfoType
                {
                    public string FirstName { get; set; } = null!;
                    public string LastName { get; set; } = null!;
                    public FileDtoRes? Avatar { get; set; } = null!;
                }
                public string Id { get; set; } = null!;
                public UserInfoType UserInfo { get; set; } = null!;
            }
            public string Id { get; set; } = null!;
            public string Title { get; set; } = null!;
            public ClientProfileType ClientProfile { get; set; } = null!;
        }
        public string Id { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CreatedAt { get; set; } = null!;
        public ProjectType Project { get; set; } = null!;
    }

    public UserInfoType UserInfo { get; set; } = null!;
    public string? Bio { get; set; } = null!;
    public List<SkillType> Skills { get; set; } = [];
    public CVType? Cv { get; set; } = null!;
}