namespace LancerPlace_.NET_Demo.Src.Dtos.Conversations.Freelancer;

public class ConversationDtoRes
{
    public class MateUserType
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? AvatarUrl { get; set; } = null!;
        public string ClientProfileId { get; set; } = null!;
    }
    public string Id { get; set; } = null!;
    public MateUserType MateUser { get; set; } = null!;
}