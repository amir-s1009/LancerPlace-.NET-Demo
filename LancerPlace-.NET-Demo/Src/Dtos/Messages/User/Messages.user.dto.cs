using LancerPlace.NET.Demo.Src.Enums;
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
    public string ConversationId { get; set; } = null!;
    public MessageSchema Message { get; set; } = null!;
}

public class EditMessageDtoReq
{
    public string Text { get; set; } = null!;
}

public class MessageListItemDtoRes
{
    public string Id { get; set; } = null!;
    public MessageType Type { get; set; }
    public string? Text { get; set; } = null!;
    public FileDtoRes? File { get; set; } = null!;
    public string CreatedAt { get; set; } = null!;
    public string? UpdatedAt { get; set; } = null!;
    public bool IsMine { get; set; }
    public bool IsSeen { get; set; }
}