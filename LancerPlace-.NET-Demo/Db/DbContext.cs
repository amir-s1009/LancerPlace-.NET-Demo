
using Microsoft.EntityFrameworkCore;
using LancerPlace_.NET_Demo.Src.Models;

namespace LancerPlace.NET.Demo.Src.Data;

public class Db : DbContext
{
    public Db(DbContextOptions<Db> options)
        : base(options)
    {
    }

    public DbSet<RegisterPending> RegisterPendings => Set<RegisterPending>();
    public DbSet<User> Users => Set<User>();

    public DbSet<FreelancerProfile> FreelancerProfiles => Set<FreelancerProfile>();
    public DbSet<FreelancerSkill> FreelancerSkills => Set<FreelancerSkill>();
    public DbSet<Portfolio> Portfolios => Set<Portfolio>();
    public DbSet<ClientProfile> ClientProfiles => Set<ClientProfile>();

    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Application> Applications => Set<Application>();

    public DbSet<Conversation> Conversations => Set<Conversation>();
    public DbSet<Message> Messages => Set<Message>();

    public DbSet<Spam> Spams => Set<Spam>();
    public DbSet<Endorsement> Endorsements => Set<Endorsement>();

    public DbSet<Token> Tokens => Set<Token>();
    public DbSet<TokenStore> TokenStores => Set<TokenStore>();
    public DbSet<TokenSnapshot> TokenSnapshots => Set<TokenSnapshot>();

    public DbSet<Transaction> Transactions => Set<Transaction>();
    public DbSet<FinancialSupport> FinancialSupports => Set<FinancialSupport>();

    public DbSet<ProjectPromo> ProjectPromos => Set<ProjectPromo>();
    public DbSet<ProjectPromoStore> ProjectPromoStores => Set<ProjectPromoStore>();
    public DbSet<ProjectPromoSnapshot> ProjectPromoSnapshots => Set<ProjectPromoSnapshot>();

    public DbSet<ContactUs> ContactUs => Set<ContactUs>();
    public DbSet<LancerPlace_.NET_Demo.Src.Models.File> Files => Set<LancerPlace_.NET_Demo.Src.Models.File>();

    public DbSet<ClientCollaborationPreference> ClientCollaborationPreferences
        => Set<ClientCollaborationPreference>();

    public DbSet<CV> Cvs => Set<CV>();
    public DbSet<Bookmark> Bookmarks => Set<Bookmark>();

    public DbSet<LoginAttempt> LoginAttempts => Set<LoginAttempt>();
    public DbSet<Log> Logs => Set<Log>();
    public DbSet<Moderation> Moderations => Set<Moderation>();
}
