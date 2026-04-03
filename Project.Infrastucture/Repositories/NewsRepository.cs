using Project.Application.Interfaces.Repositories;
using Project.Domain.Entities;
using Project.Infrastructure.Persistence;

namespace Project.Infrastructure.Repositories;

public class NewsRepository : BaseRepository<News>, INewsRepository
{
    public NewsRepository(AppDbContext context) : base(context)
    {
    }
}
