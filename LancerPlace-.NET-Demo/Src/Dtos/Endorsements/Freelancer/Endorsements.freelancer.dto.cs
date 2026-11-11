using LancerPlace_.NET_Demo.Src.Dtos.File;

namespace LancerPlace_.NET_Demo.Src.Dtos.Endorsements.Freelancer;

public class EndorsementListItemDtoRes
{
    public class ClientProfileType
    {
        public class UserInfoType
        {
            public string FirstName { get; set; } = null!;
            public string LastName { get; set; } = null!;
            public FileDtoRes? Avatar { get; set; } = null!;
        }
        public Guid Id { get; set; } = null!;
        public UserInfoType UserInfo { get; set; } = null!;
    }
    public class ProjectType
    {
        public Guid Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
    public Guid Id { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string CreatedAt { get; set; } = null!;
    public ClientProfileType ClientProfile { get; set; } = null!;
    public ProjectType project { get; set; } = null!;
}