using Project.Application.DTOs.Service;
using Project.Domain.Entities;


namespace Project.Application.Mappings;

public static class ServiceMappings
{
    public static ServiceManageDto ToManageDto(this Service service)
    {
        return new ServiceManageDto
        {
            Id = service.Id,
            Caption = service.Caption,
            Image = service.Image,
            Title = service.Title,
            Description = service.Description,
            FullInfo = service.FullInfo,
            CreateDate = service.CreateDate,
            LastUpdate = service.LastUpdate,
            PublicationDate = service.PublicationDate,
            IsPublished = service.IsPublished
        };
    }


    public static ServicePublicDto ToPublicDto(this Service service)
    {
        return new ServicePublicDto
        {
            Id = service.Id,
            Caption = service.Caption,
            Image = service.Image,
            Title = service.Title,
            Description = service.Description,
            FullInfo = service.FullInfo,
            PublicationDate = service.PublicationDate
        };
    }

}
