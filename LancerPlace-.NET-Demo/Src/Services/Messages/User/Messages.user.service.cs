
using LancerPlace.NET.Demo.Src.Data;
using LancerPlace_.NET_Demo.Src.Dtos.Messages.User;
using LancerPlace_.NET_Demo.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace LancerPlace_.NET_Demo.Src.Services.Messages;

public class MessagesUserService(Db db)
{
    public async Task Create(Guid userId, CreateMessageDtoReq message)
    {
        User user = await db.Users.FindAsync(userId) ?? throw new ApplicationException(System.Net.HttpStatusCode.NotFound, "اطلاعات کاربری شما یافت نشد!");
        Conversation conversation =
        await db.Conversations
        .Include(props => props.Application) // Alert!!!!
        .FirstOrDefaultAsync(c =>
            c.Id == message.ConversationId &&
            (c.Application.FreelancerProfile.UserId == userId || c.Application.Project.ClientProfile.UserId == userId)
        )
        ?? throw new ApplicationException(System.Net.HttpStatusCode.NotFound, "مکالمه مورد نظر یافت نشد!");
        bool iAmFreelancer = conversation.Application.FreelancerProfile.UserId == userId;
        if (iAmFreelancer)
        {
            if (conversation.Status != ConversationStatus.OPEN) throw new ApplicationException(System.Net.HttpStatusCode.BadRequest, "مکالمه توسط کارفرما هنوز آغاز نشده است!");
            Message messageCreated = new()
            {
                ConversationId = conversation.Id,
                IsSeen = false,
                Type = message.Message.Type,
                Text = message.Message.Text,
                Files = message.Message.File != null ? new List<Models.File> {
                    new(){
                        MimeType = message.Message.File.MimeType,
                        OriginalName = message.Message.File.OriginalName,
                        SizeByte = message.Message.File.SizeByte,
                        StorageKey = message.Message.File.Key,
                        StorageUrl = message.Message.File.Url,
                    }
                } : [],
                UserId = userId,
            };
            await db.Messages.AddAsync(messageCreated);
        }
        else
        {
            if (conversation.Status != ConversationStatus.OPEN)
                conversation.Status = ConversationStatus.OPEN;
            Message messageCreated = new()
            {
                ConversationId = conversation.Id,
                IsSeen = false,
                Type = message.Message.Type,
                Text = message.Message.Text,
                Files = message.Message.File != null ? new List<Models.File> {
                    new(){
                        MimeType = message.Message.File.MimeType,
                        OriginalName = message.Message.File.OriginalName,
                        SizeByte = message.Message.File.SizeByte,
                        StorageKey = message.Message.File.Key,
                        StorageUrl = message.Message.File.Url,
                    }
                } : [],
                UserId = userId,
            };
            await db.Messages.AddAsync(messageCreated);
        }
        await db.SaveChangesAsync();
    }
}