
using LancerPlace_.NET_Demo.Src.Dtos.File;

namespace LancerPlace_.NET_Demo.Src.Dtos.Messages.User;

public class CreateMessageDtoReq
{
    public class MessageSchema
    {
        public MessageType Type { get; set; }
        public string? Text { get; set; } = null!;
        public FileDtoReq? File { get; set; } = null!;
    }
    public Guid ConversationId { get; set; }
    public MessageSchema Message { get; set; } = null!;
}

public class EditMessageDtoReq
{
    public string Text { get; set; } = null!;
}

public class MessageListItemDtoRes
{
    public Guid Id { get; set; }
    public MessageType Type { get; set; }
    public string? Text { get; set; } = null!;
    public FileDtoRes? File { get; set; } = null!;
    public string CreatedAt { get; set; } = null!;
    public string? UpdatedAt { get; set; } = null!;
    public bool IsMine { get; set; }
    public bool IsSeen { get; set; }
}