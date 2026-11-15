
using LancerPlace.NET.Demo.Src.Data;
using LancerPlace_.NET_Demo.Endpoints.Applications.Freelancer;
using LancerPlace_.NET_Demo.Endpoints.Bookmarks.User;
using LancerPlace_.NET_Demo.Endpoints.Messages.User;
using LancerPlace_.NET_Demo.Middlewares;
using LancerPlace_.NET_Demo.Src;
using LancerPlace_.NET_Demo.Src.Services.Applications.Freelancer;
using LancerPlace_.NET_Demo.Src.Services.Bookmarks.User;
using LancerPlace_.NET_Demo.Src.Services.Messages;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddCors();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();
builder.Services.AddAuthentication();
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("USER", (policy) => policy.RequireClaim("role", "USER"));
    options.AddPolicy("ADMIN", (policy) => policy.RequireClaim("role", "ADMIN"));
});
builder.Services.AddDbContext<Db>(options =>
{
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    );
});

builder.Services.AddScoped<BookmarksUserService>();
builder.Services.AddScoped<ApplicationsFreelancerService>();
builder.Services.AddScoped<MessagesUserService>();

var app = builder.Build();

app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors();
app.UseHttpsRedirection();
app.UseMiddleware<PreventConcurrentRequestsMiddleware>();
app.UseAuthentication();
app.UseAuthorization();

app.MapBookmarksUserEndpoints();
app.MapApplicationsFreelancerEndpoints();
app.MapMessagesUserEndpoints();

app.Run();
