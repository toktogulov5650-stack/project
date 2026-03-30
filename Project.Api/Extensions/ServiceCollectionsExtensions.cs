using Microsoft.EntityFrameworkCore;
using Project.Application.Interfaces.Repositories;
using Project.Application.Interfaces.Services;
using Project.Application.Services;
using Project.Infrastructure.Persistence;
using Project.Infrastructure.Repositories;
using Project.Infrastructure.Services;



namespace Project.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<INewsRepository, NewsRepository>();
        services.AddScoped<INewsService, NewsService>();
        services.AddScoped<IDateTimeProvaider, DateTimeProvider>();

        services.AddScoped<IArticleRepositories, ArticleRepositories>();
        services.AddScoped<IArticleService, ArticleService>();
        services.AddScoped<IDateTimeProvaider, DateTimeProvider>();

        services.AddScoped<IServiceRepositories, ServiceRepositories>();
        services.AddScoped<IServiceServices, ServiceServices>();
        services.AddScoped<IDateTimeProvaider, DateTimeProvider>();

        return services;
    }
}
