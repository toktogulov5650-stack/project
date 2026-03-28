
using Project.Application.DTOs.News;


namespace Project.Application.Interfaces.Services;

public interface INewsService
{
    Task<List<NewsManageDto>> GetManageListAsync();

    Task<NewsManageDto?> GetManageByIdAsync(int id);

    Task<NewsManageDto> CreateAsync(NewsCreateRequest request);

    Task<NewsManageDto?> UpdateAsync(int id, NewsUpdateRequest request);

    Task<bool> DeleteAsync(int id);

    Task<List<NewsPublicDto>> GetPublicListAsync();

    Task<NewsPublicDto?> GetPublicByIdAsync(int id);
}