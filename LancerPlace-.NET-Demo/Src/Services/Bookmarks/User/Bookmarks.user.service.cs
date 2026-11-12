using LancerPlace.NET.Demo.Src.Data;
using LancerPlace_.NET_Demo.Src.Dtos.Bookmarks.User;
using LancerPlace_.NET_Demo.Src.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace LancerPlace_.NET_Demo.Src.Services.Bookmarks.User;

public class BookmarksUserService
{
    public async Task ToggleBookmark(Guid userId, BookmarkTarget target, Guid targetId, Db db)
    {
        if (target == BookmarkTarget.PROJECT)
        {
            Project projectTarget;
            projectTarget = await db.Projects.FindAsync(targetId) ?? throw new ApplicationException(HttpStatusCode.NotFound, "پروژه مورد نظر یافت نشد!");
            if (projectTarget.ClientProfile.UserId == userId) throw new ApplicationException(HttpStatusCode.BadRequest, "شما پروزه خودتان را نمیتوانید نشان کنید!");
            Bookmark? bookmark = await db.Bookmarks.FirstOrDefaultAsync(b => b.UserId == userId && b.Target == target && b.ProjectId == (target == BookmarkTarget.PROJECT ? targetId : null));
            if (bookmark is null)
            {
                Bookmark bookmarkCreated = new()
                {
                    ProjectId = projectTarget.Id,
                    Target = BookmarkTarget.PROJECT,
                    UserId = userId,
                };
                await db.Bookmarks.AddAsync(bookmarkCreated);
            }
            else
            {
                db.Bookmarks.Remove(bookmark);
            }
        }
        await db.SaveChangesAsync();
    }

    public async Task<List<BookmarkListItemDtoRes>> GetAllBookmarks(Guid userId, BookmarkTarget target, Db db)
    {

        List<BookmarkListItemDtoRes> bookmarks = await db.Bookmarks
        .Where(b => b.UserId == userId && b.Target == target)
        .Select(b => new BookmarkListItemDtoRes()
        {
            Target = b.Target,
            Project = b.Project != null ? new()
            {
                Id = b.Project.Id,
                Budget = b.Project.Budget,
                DeadlineDays = b.Project.DeadlineDays,
                PublishedAt = b.Project.PublishedAt != null ? b.Project.PublishedAt.ToString() : null,
                Title = b.Project.Title,
                Categories = new List<BookmarkListItemDtoRes.ProjectType.CategoryType>{
                    new(){
                        Id = b.Project.Category.Id,
                        Title = b.Project.Category.Title,
                        ParentId = b.Project.Category.ParentId
                    }
                }
            } : null
        })
        .ToListAsync();

        foreach (var bookmark in bookmarks)
        {
            if (target == BookmarkTarget.PROJECT && bookmark.Project != null)
            {
                List<BookmarkListItemDtoRes.ProjectType.CategoryType> parentCategories = [];
                BookmarkListItemDtoRes.ProjectType.CategoryType currentCategory = bookmark.Project.Categories[0];
                while (currentCategory.ParentId != null)
                {
                    Category? parentCategory = await db.Categories.FindAsync(currentCategory.ParentId);
                    if (parentCategory == null)
                    {
                        break;
                    }
                    parentCategories.Add(new()
                    {
                        Id = parentCategory.Id,
                        Title = parentCategory.Title,
                        ParentId = parentCategory.ParentId,
                    });
                    currentCategory = new()
                    {
                        Id = parentCategory.Id,
                        Title = parentCategory.Title,
                        ParentId = parentCategory.ParentId,
                    };
                }
                bookmark.Project.Categories.AddRange(parentCategories);
            }
        }
        return bookmarks;
    }
}