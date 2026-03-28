using Project.Domain.Entities;


namespace Project.Application.Interfaces.Repositories;

public interface IServiceRepositories
{
    Task<List<Service>> GetAllAsync();

    Task<Service?> GetByIdAsync(int id);

    Task AddAsync(Service service);

    void Update(Service service);

    void Delete(Service service);

    Task<List<Service>> GetPublishedAsync();

    Task<Service?> GetPublishedByIdAsync(int id);

    Task SaveChangesAsync(); 

}
