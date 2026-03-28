using Project.Application.DTOs.News;
using Project.Application.Interfaces.Services;
using Project.Application.Mappings;
using Project.Domain.Entities;
using Project.Application.Interfaces.Repositories;

namespace Project.Application.Services;

public class NewsService : INewsService
{
    private readonly INewsRepository _newsRepository;
    private readonly IDateTimeProvaider _dateTimeProvaider;


    public NewsService(
        INewsRepository newsRepository,
        IDateTimeProvaider dateTimeProvaider)
    {
        _newsRepository = newsRepository;
        _dateTimeProvaider = dateTimeProvaider;
    }


    public async Task<List<NewsManageDto>> GetManageListAsync()
    {
        var newsList = await _newsRepository.GetAllAsync();
        return newsList.Select(a => a.ToManageDto()).ToList();
    }

    public async Task<NewsManageDto?> GetManageByIdAsync(int id)
    {
        var news = await _newsRepository.GetByIdAsync(id);
        return news?.ToManageDto();
    } 


    public async Task<NewsManageDto> CreateAsync(NewsCreateRequest request)
    {
        var news = new News
        { 
            Caption = request.Caption,
            Image = request.Image,
            Title = request.Title,
            Description = request.Description,
            FullInfo = request.FullInfo,
            PublicationDate = request.PublicationDate,
            IsPublished = request.IsPublished,
            CreateDate = _dateTimeProvaider.UtcNow
        };

        await _newsRepository.AddAsync(news);
        await _newsRepository.SaveChangesAsync();

        return news.ToManageDto();
    }


    public async Task<NewsManageDto?> UpdateAsync(int id, NewsUpdateRequest request)
    {
        var news = await _newsRepository.GetByIdAsync(id);

        if (news is null)
            return null;

        news.Caption = request.Caption;
        news.Image = request.Image;
        news.Title = request.Title;
        news.Description = request.Description;
        news.FullInfo = request.FullInfo;

        _newsRepository.Update(news);
        await _newsRepository.SaveChangesAsync();

        return news.ToManageDto();
    }


    public async Task<bool> DeleteAsync(int id)
    {
        var news = await _newsRepository.GetByIdAsync(id);

        if (news is null)
            return false;

        _newsRepository.Delete(news);
        await _newsRepository.SaveChangesAsync();

        return true;
    }


    public async Task<List<NewsPublicDto>> GetPublicListAsync()
    {
        var newsList = await _newsRepository.GetPublishedAsync();
        return newsList.Select(a => a.ToPublicDto()).ToList();
    }


    public async Task<NewsPublicDto?> GetPublicByIdAsync(int id)
    {
        var news = await _newsRepository.GetPublishedByIdAsync(id);

        if (news is null)
            return null;

        return news.ToPublicDto();
    }
}
