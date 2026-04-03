using Project.Application.Interfaces.Repositories;
using Project.Domain.Entities;
using Project.Infrastructure.Persistence;

namespace Project.Infrastructure.Repositories;

public class ArticleRepositories : BaseRepository<Article>, IArticleRepositories
{
    public ArticleRepositories(AppDbContext context) : base(context)
    {
    }
}
