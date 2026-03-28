using Project.Domain.Entities;
using Project.Application.Interfaces.Repositories;
using Project.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace Project.Infrastructure.Repositories;

public class ServiceRepositories : IServiceRepositories
{
    private readonly AppDbContext _context;

    public ServiceRepositories(AppDbContext context)
    {
        _context = context;
    }


    public async Task<List<Service>> GetAllAsync()
    {
        return await _context.Service
            .OrderByDescending(a => a.PublicationDate)
            .ToListAsync();
    }


    public async Task<Service?> GetByIdAsync(int id)
    {
        return await _context.Service
            .FirstOrDefaultAsync(a => a.Id == id);
    }


    public async Task AddAsync(Service service)
    {
        await _context.Service.AddAsync(service);
    }


    public void Update(Service service)
    {
        _context.Service.Update(service);
    }


    public void Delete(Service service)
    {
        _context.Service.Remove(service);
    }


    public async Task<List<Service>> GetPublishedAsync()
    {
        return await _context.Service
            .OrderByDescending(a => a.PublicationDate)
            .ToListAsync();
    }


    public async Task<Service?> GetPublishedByIdAsync(int id)
    {
        return await _context.Service
            .FirstOrDefaultAsync(a => a.Id == id && a.IsPublished);
    }


    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
