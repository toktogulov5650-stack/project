using Project.Domain.Common;

namespace Project.Application.Interfaces.Repositories;

public interface IRepository<TEntity> where TEntity : Component
{
    Task<List<TEntity>> GetAllAsync();

    Task<TEntity?> GetByIdAsync(int id);

    Task AddAsync(TEntity entity);

    void Update(TEntity entity);

    void Delete(TEntity entity);

    Task<List<TEntity>> GetPublishedAsync();

    Task<TEntity?> GetPublishedByIdAsync(int id);

    Task SaveChangesAsync();
}
