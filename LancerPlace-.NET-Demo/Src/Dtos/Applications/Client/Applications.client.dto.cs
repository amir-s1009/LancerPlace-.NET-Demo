
using LancerPlace_.NET_Demo.Src.Dtos.File;

namespace LancerPlace_.NET_Demo.Src.Dtos.Applications.Client;

public class ApplicationListItemDtoRes
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
    public FreelancerProfileType FreelancerProfile { get; set; } = null!;
    public long Budget { get; set; }
    public string CreatedAt { get; set; } = null!;
    public ApplicationStatus Status { get; set; }
    public string Description { get; set; } = null!;
}

public class ApplicationDetailDtoRes
{
    public class EndorsementType
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = null!;
    }
    public Guid Id { get; set; }
    public ApplicationStatus Status { get; set; }
    public string CreatedAt { get; set; } = null!;
    public long Budget { get; set; }
    public int DeadlineDays { get; set; }
    public string Description { get; set; } = null!;
    public EndorsementType? Endorsement { get; set; } = null!;
}