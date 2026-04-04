using Project.Application.DTOs.Service;
using Project.Application.Interfaces.Services;


namespace Project.Application.Interfaces.Services;

public interface IServiceServices : 
    IServices<ServiceManageDto, ServicePublicDto, ServiceCreateRequest, ServiceUpdateRequest>
{
}
