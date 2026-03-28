using Microsoft.EntityFrameworkCore;
using Project.Application.Interfaces.Repositories;
using Project.Domain.Entities;
using Project.Infrastructure.Persistence;


namespace Project.Infrastructure.Repositories;

public class ArticleRepositories : IArticleRepositories
{
    private readonly AppDbContext _context;

    public  ArticleRepositories(AppDbContext context)
    {
        _context = context;
    }


    public async Task<List<Article>> GetAllAsync()
    {
        return await _context.Article
            .OrderByDescending(a => a.PublicationDate)
            .ToListAsync();
    }


    public async Task<Article?> GetByIdAsync(int id)
    {
        return await _context.Article.
            FirstOrDefaultAsync(a => a.Id == id);
    }


    public async Task AddAsync(Article article)
    {
        await _context.Article.AddAsync(article);
    }


    public void Update(Article article)
    {
        _context.Article.Update(article);
    }


    public void Delete(Article article)
    {
        _context.Article.Remove(article);
    }


    public Task<List<Article>> GetPublishedAsync()
    {
        return _context.Article
            .OrderByDescending(a => a.IsPublished)
            .ToListAsync();
    }


    public async Task<Article?> GetPublishedByIdAsync(int id)
    {
        return await _context.Article
            .FirstOrDefaultAsync(a => a.Id == id && a.IsPublished);
    }


    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
