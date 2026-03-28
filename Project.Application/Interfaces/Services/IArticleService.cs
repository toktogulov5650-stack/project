using Project.Application.DTOs.Article;

namespace Project.Application.Interfaces.Services;

public interface IArticleService
{
    Task<List<ArticleManageDto>> GetManageListAsync();

    Task<ArticleManageDto?> GetManageByIdAsync(int id);

    Task<ArticleManageDto> CreateAsync(ArticleCreateRequest request);

    Task<ArticleManageDto?> UpdateAsync(int id, ArticleUpdateRequest request);

    Task<bool> DeleteAsync(int id);

    Task<List<ArticlePublicDto>> GetPublicListAsync();

    Task<ArticlePublicDto?> GetPublicByIdAsync(int id);
}
