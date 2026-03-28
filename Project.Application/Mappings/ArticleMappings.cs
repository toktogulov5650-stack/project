using Project.Application.DTOs.Article;
using Project.Domain.Entities;


namespace Project.Application.Mappings;

public static class ArticleMappings
{
    public static ArticleManageDto ToManageDto(this Article article)
    {
        return new ArticleManageDto
        {
            Id = article.Id,
            Caption = article.Caption,
            Image = article.Image,
            Title = article.Title,
            Description = article.Description,
            FullInfo = article.FullInfo,
            CreateDate = article.CreateDate,
            LastUpdate = article.LastUpdate,
            PublicationDate = article.PublicationDate,
            IsPublished = article.IsPublished
        };
    }


    public static ArticlePublicDto ToPublicDto(this Article article)
    {
        return new ArticlePublicDto
        {
            Id = article.Id,
            Caption = article.Caption,
            Image = article.Image,
            Title = article.Title,
            Description = article.Description,
            FullInfo = article.FullInfo,
            PublicationDate = article.PublicationDate
        };
    }
}
