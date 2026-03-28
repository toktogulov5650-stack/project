using Project.Domain.Entities;

namespace Project.Application.Interfaces.Repositories;

public interface IArticleRepositories
{
    Task<List<Article>> GetAllAsync();

    Task<Article?> GetByIdAsync(int id);

    Task AddAsync(Article article);

    void Update(Article article);

    void Delete(Article article);

    Task<List<Article>> GetPublishedAsync(); 

    Task<Article?> GetPublishedByIdAsync(int id);

    Task SaveChangesAsync();
}