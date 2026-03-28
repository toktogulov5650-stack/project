using Project.Domain.Entities;


namespace Project.Application.Interfaces.Repositories;

public interface INewsRepository
{
    Task<List<News>> GetAllAsync();

    Task<News?> GetByIdAsync(int id);

    Task AddAsync(News news);

    void Update(News news);

    void Delete(News news);

    Task<List<News>> GetPublishedAsync();

    Task<News?> GetPublishedByIdAsync(int id);

    Task SaveChangesAsync();
}