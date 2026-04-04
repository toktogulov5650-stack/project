
using Project.Application.DTOs.News;
using Project.Application.Interfaces.Services;


namespace Project.Application.Interfaces.Services;

public interface INewsService :
    IServices<NewsManageDto, NewsPublicDto, NewsCreateRequest, NewsUpdateRequest>
{
}