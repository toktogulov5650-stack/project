using Project.Application.DTOs.Service;
using Project.Application.Interfaces.Services;
using Project.Application.Mappings;
using Project.Application.Interfaces.Repositories;
using Project.Domain.Entities;

namespace Project.Application.Services;

public class ServiceServices : IServiceServices
{
    private readonly IServiceRepositories _serviceRepositories;
    private readonly IDateTimeProvaider _dateTimeProvaider;

    public ServiceServices(
        IServiceRepositories serviceRepositories,
        IDateTimeProvaider dateTimeProvaider)
    {
        _serviceRepositories = serviceRepositories;
        _dateTimeProvaider = dateTimeProvaider;
    }


    public async Task<List<ServiceManageDto>> GetManageListAsync()
    {
        var serviceList = await _serviceRepositories.GetAllAsync();
        return serviceList.Select(a => a.ToManageDto()).ToList();
    }


    public async Task<ServiceManageDto?> GetManageById(int id)
    {
        var service = await _serviceRepositories.GetByIdAsync(id);
        return service?.ToManageDto();
    }


    public async Task<ServiceManageDto> CreateAsync(ServiceCreateRequest request)
    {
        var service = new Service
        {
            Caption = request.Caption,
            Image = request.Image,
            Title = request.Title,
            Description = request.Description,
            FullInfo = request.FullInfo,
            PublicationDate = request.PublicationDate,
            IsPublished = request.IsPublished
        };

        await _serviceRepositories.AddAsync(service);
        await _serviceRepositories.SaveChangesAsync();

        return service.ToManageDto();
    }


    public async Task<ServiceManageDto?> UpdateAsync(int id, ServiceUpdateRequest request)
    {
        var service = await _serviceRepositories.GetByIdAsync(id);

        if (service is null)
            return null;

        service.Caption = request.Caption;
        service.Image = request.Image;
        service.Title = request.Title;
        service.Description = request.Description;
        service.FullInfo = request.FullInfo;
        service.IsPublished = request.IsPublished;

        _serviceRepositories.Update(service);
        await _serviceRepositories.SaveChangesAsync();

        return service?.ToManageDto();
    }


    public async Task<bool> DeleteAsync(int id)
    {
        var service = await _serviceRepositories.GetByIdAsync(id);

        if (service is null)
            return false;

        _serviceRepositories.Delete(service);
        await _serviceRepositories.SaveChangesAsync();

        return true;
    }


    public async Task<List<ServicePublicDto>> GetPublicListAsync()
    {
        var serviceList = await _serviceRepositories.GetAllAsync();
        return serviceList.Select(a => a.ToPublicDto()).ToList();
    }


    public async Task<ServicePublicDto?> GetPublicByIdAsync(int id)
    {
        var service = await _serviceRepositories.GetByIdAsync(id);

        if (service is null)
            return null;

        return service.ToPublicDto();
    }
}
