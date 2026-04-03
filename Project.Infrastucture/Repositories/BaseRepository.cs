using Microsoft.EntityFrameworkCore;
using Project.Application.Interfaces.Repositories;
using Project.Domain.Common;
using Project.Infrastructure.Persistence;

namespace Project.Infrastructure.Repositories;

public class BaseRepository<TEntity> : IRepository<TEntity>
    where TEntity : Component
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<TEntity> _dbSet;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await _dbSet
            .OrderByDescending(x => x.PublicationDate)
            .ToListAsync();
    }

    public async Task<TEntity?> GetByIdAsync(int id)
    {
        return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);
    }

    public void Delete(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task<List<TEntity>> GetPublishedAsync()
    {
        return await _dbSet
            .Where(x => x.IsPublished)
            .OrderByDescending(x => x.PublicationDate)
            .ToListAsync();
    }

    public async Task<TEntity?> GetPublishedByIdAsync(int id)
    {
        return await _dbSet.FirstOrDefaultAsync(x => x.Id == id && x.IsPublished);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
