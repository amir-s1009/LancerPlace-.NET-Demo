using LancerPlace.NET.Demo.Src.Data;
using LancerPlace_.NET_Demo.Src.Dtos.Applications.Freelancer;
using LancerPlace_.NET_Demo.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace LancerPlace_.NET_Demo.Src.Services.Applications.Freelancer;

public class ApplicationsFreelancerService(Db db)
{
    public async Task Create(Guid userId, CreateApplicationDtoReq application)
    {
        Project project = await db.Projects.FindAsync(application.ProjectId) ?? throw new ApplicationException(System.Net.HttpStatusCode.NotFound, "پروژه مورد نظر یافت نشد!");
        if (project.Status != ProjectStatus.HIRING) throw new ApplicationException(System.Net.HttpStatusCode.BadRequest, "در حال حاضر امکان ثبت پیشنهاد وجود ندارد!");

        FreelancerProfile freelancerProfile = await db.FreelancerProfiles
        .Include(props => props.Moderations.Where(m => m.EndsAt > DateTime.UtcNow && m.Type == ModerationType.FREELANCER_CREATE_APPLICATION))
        .Include(props => props.Tokens.Where(t => t.IsActive && t.EndsAt > DateTime.UtcNow))
        .Include(props => props.Applications.Where(a => a.ProjectId == application.ProjectId))
        .FirstOrDefaultAsync(fp => fp.UserId == userId) ?? throw new ApplicationException(System.Net.HttpStatusCode.NotFound, "پروفایل شما یافت نشد!");

        if (freelancerProfile.Moderations.Count > 0) throw new ApplicationException(System.Net.HttpStatusCode.BadRequest, "شما به دلیل رفتار غیر حرفه ای، موقتا امکان ثبت پیشنهاد را ندارید!");
        if (freelancerProfile.Tokens.Count < 1) throw new ApplicationException(System.Net.HttpStatusCode.BadRequest, "شما هیچ بسته اعتباری فعالی ندارید!");
        if (freelancerProfile.Applications.Count > 0) throw new ApplicationException(System.Net.HttpStatusCode.BadRequest, "شما قبلا روی این آگهی پیشنهاد داده اید!");
        Token activeToken = freelancerProfile.Tokens.First();
        activeToken.Use();
        Application applicationCreated = new()
        {
            ProjectId = application.ProjectId,
            Coverletter = application.Application.Description,
            SuggestionAmount = application.Application.Budget,
            DeadlineDays = application.Application.DeadlineDays,
        };
        freelancerProfile.Applications.Add(applicationCreated);

        await db.SaveChangesAsync();
    }
}