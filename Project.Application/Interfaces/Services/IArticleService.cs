using Project.Application.DTOs;
using Project.Application.DTOs.Article;
using Project.Application.Services;

namespace Project.Application.Interfaces.Services;

public interface IArticleService : 
    IServices<ArticleManageDto, ArticlePublicDto, ArticleCreateRequest, ArticleUpdateRequest>
{
}
