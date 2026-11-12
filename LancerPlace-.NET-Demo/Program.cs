
using LancerPlace.NET.Demo.Src.Data;
using LancerPlace_.Net_Demo.Endpoints.Bookmarks.User;
using LancerPlace_.NET_Demo.Src;
using LancerPlace_.NET_Demo.Src.Services.Bookmarks.User;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddCors();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();
builder.Services.AddDbContext<Db>(options =>
{
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    );
});

builder.Services.AddScoped<BookmarksUserService>();

var app = builder.Build();

app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors();
app.UseHttpsRedirection();

app.MapBookmarksUserEndpoints();

app.Run();
