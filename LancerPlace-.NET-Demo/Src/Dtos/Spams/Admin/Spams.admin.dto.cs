using LancerPlace.NET.Demo.Src.Enums;
using LancerPlace_.NET_Demo.Src.Dtos.File;

namespace LancerPlace_.NET_Demo.Src.Dtos.Spams.Admin;

public class SpamListItemDtoRes
{
    public Guid Id { get; set; } = null!;
    public SpamType Type { get; set; }
    public SpamStatus Status { get; set; }
    public string CreatedAt { get; set; } = null!;
}

public class SpamDetailDtoRes
{
    public class ProjectType
    {
        public class CategoryType
        {
            public Guid Id { get; set; } = null!;
            public string Title { get; set; } = null!;
            public string? ParentId { get; set; } = null!;
        }
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
        public Guid Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public List<CategoryType> Categories { get; set; } = [];
        public string Description { get; set; } = null!;
        public long Budget { get; set; }
        public ProjectStatus Status { get; set; }
        public string CreatedAt { get; set; } = null!;
        public int ApplicationsCount { get; set; }
        public ClientProfileType ClientProfile { get; set; } = null!;
    }
    public class ApplicationType
    {
        public class FreelancerProfileType
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
        public Guid Id { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long Budget { get; set; }
        public ApplicationStatus Status { get; set; }
        public string CreatedAt { get; set; } = null!;
        public FreelancerProfileType FreelancerProfile { get; set; } = null!;
        public ProjectType Project { get; set; } = null!;
    }
    public class ConversationType
    {
        public class MessageType
        {
            public class UserType
            {
                public string? FreelancerProfileId { get; set; } = null!;
                public string? ClientProfileId { get; set; } = null!;
                public string FirstName { get; set; } = null!;
                public string LastName { get; set; } = null!;
                public bool AsFreelancer { get; set; }
                public FileDtoRes? Avatar { get; set; }
            }
            public Guid Id { get; set; } = null!;
            public MessageType Type { get; set; } = null!;
            public string? Text { get; set; } = null!;
            public FileDtoRes? File { get; set; } = null!;
            public bool IsSeen { get; set; }
            public UserType User { get; set; } = null!;
        }
        public Guid Id { get; set; } = null!;
        public string CreatedAt { get; set; } = null!;
        public List<MessageType> Messages { get; set; } = null!;
    }
    public class EndorsementType
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
        public Guid Id { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CreatedAt { get; set; } = null!;
        public EndorsementStatus Status { get; set; }
        public ClientProfileType ClientProfile { get; set; } = null!;
        public ApplicationType Application { get; set; } = null!;
    }
    public class ModerationType
    {
        public Guid Id { get; set; } = null!;
        public string Message { get; set; } = null!;
        public ModerationType Type { get; set; } = null!;
        public string CreatedAt { get; set; } = null!;
        public string? EndsAt { get; set; } = null!;
        public TargetProfile TargetProfile { get; set; }
        public string? FreelancerProfileId { get; set; } = null!;
        public string? ClientProfileId { get; set; } = null!;
    }
    public Guid Id { get; set; } = null!;
    public SpamType Type { get; set; }
    public SpamStatus Status { get; set; }
    public string CreatedAt { get; set; } = null!;
    public string Message { get; set; } = null!;
    public ProjectType? Project { get; set; } = null!;
    public ApplicationType? Application { get; set; } = null!;
    public ConversationType? Conversation { get; set; } = null!;
    public EndorsementType? Endorsement { get; set; } = null!;
    public List<ModerationType> Moderations { get; set; } = null!;
}

public class ModerateSpamDtoReq
{
    public class ModerationType
    {
        public ModerationType Type { get; set; } = null!;
        public string Message { get; set; } = null!;
        public TargetProfile TargetProfile { get; set; }
        public string? FreelancerProfileId { get; set; } = null!;
        public string? ClientProfileId { get; set; } = null!;
        public ModerationDuration? Duration { get; set; } = null!;
    }

    public List<ModerationType> Moderations { get; set; } = [];
}