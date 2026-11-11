namespace LancerPlace_.NET_Demo.Src.Dtos.Conversations.Client;

public class ConversationDtoRes
{
    public class MateUserType
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? AvatarUrl { get; set; } = null!;
        public string FreelancerProfileId { get; set; } = null!;
    }
    public Guid Id { get; set; } = null!;
    public MateUserType MateUser { get; set; } = null!;
}