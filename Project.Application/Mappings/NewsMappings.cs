using Project.Application.DTOs.News;
using Project.Domain.Entities;

namespace Project.Application.Mappings;

public static class NewsMappings
{
    public static NewsManageDto ToManageDto(this News news)
    {
        return new NewsManageDto
        {
            Id = news.Id,
            Caption = news.Caption,
            Image = news.Image,
            Title = news.Title,
            Description = news.Description,
            FullInfo = news.FullInfo,
            CreateDate = news.CreateDate,
            LastUpdate = news.LastUpdate,
            PublicationDate = news.PublicationDate,
            IsPublished = news.IsPublished
        };
    }

    public static NewsPublicDto ToPublicDto(this News news)
    {
        return new NewsPublicDto
        {
            Id = news.Id,
            Caption = news.Caption,
            Image = news.Image,
            Title = news.Title,
            Description = news.Description,
            FullInfo = news.FullInfo,
            PublicationDate = news.PublicationDate
        };
    }
}
