using Microsoft.EntityFrameworkCore;
using Project.Application.Interfaces.Repositories;
using Project.Domain.Entities;
using Project.Infrastructure.Persistence;


namespace Project.Infrastructure.Repositories;

public class NewsRepository : INewsRepository
{
    private readonly AppDbContext _context;

    public NewsRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<News>> GetAllAsync()
    {
        return await _context.News
            .OrderByDescending(a => a.PublicationDate)
            .ToListAsync();
    }


    public async Task<List<News>> GetPublishedAsync()
    {
        return await _context.News
            .Where(a => a.IsPublished)
            .OrderByDescending(a => a.PublicationDate)
            .ToListAsync();
    }


    public async Task<News?> GetByIdAsync(int id)
    {
        return await _context.News
            .FirstOrDefaultAsync(a => a.Id == id);
    }


    public async Task<News?> GetPublishedByIdAsync(int id)
    {
        return await _context.News
            .FirstOrDefaultAsync(a => a.Id == id && a.IsPublished);
    }

     
    public async Task AddAsync(News news)
    {
        await _context.News.AddAsync(news);
    }


    public void Update(News news)
    {
        _context.News.Update(news);
            
    }

    public void Delete(News news)
    {
        _context.News.Remove(news);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
