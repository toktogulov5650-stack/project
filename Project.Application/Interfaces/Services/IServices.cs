using Project.Application.DTOs.ComponentDTOs;


namespace Project.Application.Interfaces.Services;

public interface IServices<TManageDto, TPublicDto, TCreateRequest, TUpdateRequest>
{
    Task<List<TManageDto>> GetManageListAsync();
    Task<TManageDto?> GetManageByIdAsync(int id);
    Task<TCreateRequest> CreateAsync(TCreateRequest request);
    Task<TUpdateRequest?> UpdateAsync(int id, TUpdateRequest request);
    Task<bool> DeleteAsync(int id);
    Task<List<TPublicDto>> GetPublicListAsync();
    Task<TPublicDto> GetPublicByIdAsync(int id);

}
