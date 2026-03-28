using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;


namespace Project.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<News> News => Set<News>();
    public DbSet<Article> Article => Set<Article>();

    public DbSet<Service> Service => Set<Service>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
