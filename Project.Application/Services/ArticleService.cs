using Project.Application.DTOs.Article;
using Project.Application.Interfaces.Repositories;
using Project.Application.Interfaces.Services;
using Project.Domain.Entities;
using Project.Application.Mappings;


namespace Project.Application.Services;

public class ArticleService : IArticleService
{
    private readonly IArticleRepositories _articleRepositories;
    private readonly IDateTimeProvaider _dateTimeProvaider;

    public ArticleService(
        IArticleRepositories articleRepositories,
        IDateTimeProvaider dateTimeProvaider)
    {
        _articleRepositories = articleRepositories;
        _dateTimeProvaider = dateTimeProvaider;
    }


    public async Task<List<ArticleManageDto>> GetManageListAsync()
    {
        var articleList = await _articleRepositories.GetAllAsync();
        return articleList.Select(a => a.ToManageDto()).ToList();
    }


    public async Task<ArticleManageDto?> GetManageByIdAsync(int id)
    {
        var article = await _articleRepositories.GetByIdAsync(id);
        return article?.ToManageDto();
    }


    public async Task<ArticleManageDto> CreateAsync(ArticleCreateRequest request)
    {
        var article = new Article
        {
            Caption = request.Caption,
            Image = request.Image,
            Title = request.Title,
            Description = request.Description,
            FullInfo = request.FullInfo,
            PublicationDate = request.PublicationDate,
            IsPublished = request.IsPublished
        };

        await _articleRepositories.AddAsync(article);
        await _articleRepositories.SaveChangesAsync();

        return article.ToManageDto();
    }


    public async Task<ArticleManageDto?> UpdateAsync(int id, ArticleUpdateRequest request)
    {
        var article = await _articleRepositories.GetByIdAsync(id);

        if (article is null)
            return null;

        article.Caption = request.Caption;
        article.Image = request.Image;
        article.Title = request.Title;
        article.Description = request.Description;
        article.FullInfo = request.FullInfo;

        _articleRepositories.Update(article);
        await _articleRepositories.SaveChangesAsync();

        return article.ToManageDto();
    }


    public async Task<bool> DeleteAsync(int id)
    {
        var article = await _articleRepositories.GetByIdAsync(id);

        if (article is null)
            return false;

        _articleRepositories.Delete(article);
        await _articleRepositories.SaveChangesAsync();

        return true;
    }


    public async Task<List<ArticlePublicDto>> GetPublicListAsync()
    {
        var articleList = await _articleRepositories.GetPublishedAsync();
        return articleList.Select(a => a.ToPublicDto()).ToList();
    }


    public async Task<ArticlePublicDto?> GetPublicByIdAsync(int id)
    {
        var article = await _articleRepositories.GetByIdAsync(id);

        if (article is null)
            return null;

        return article?.ToPublicDto();
    }
}
