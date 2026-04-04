using Project.Application.DTOs;
using Project.Domain.Entities;


namespace Project.Application.Interfaces.Services;

public interface IService<TEntity> where TEntity : Article
{
}
