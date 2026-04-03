using Project.Application.Interfaces.Repositories;
using Project.Domain.Entities;
using Project.Infrastructure.Persistence;

namespace Project.Infrastructure.Repositories;

public class ServiceRepositories : BaseRepository<Service>, IServiceRepositories
{
    public ServiceRepositories(AppDbContext context) : base(context)
    {
    }
}
