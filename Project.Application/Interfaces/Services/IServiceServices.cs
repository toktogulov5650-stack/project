using Project.Application.DTOs.Service;


namespace Project.Application.Interfaces.Services;

public interface IServiceServices
{
    Task<List<ServiceManageDto>> GetManageListAsync();

    Task<ServiceManageDto?> GetManageById(int id);

    Task<ServiceManageDto> CreateAsync(ServiceCreateRequest request);

    Task<ServiceManageDto?> UpdateAsync(int id, ServiceUpdateRequest request);

    Task<bool> DeleteAsync(int id);

    Task<List<ServicePublicDto>> GetPublicListAsync();

    Task<ServicePublicDto?> GetPublicByIdAsync(int id);
}
