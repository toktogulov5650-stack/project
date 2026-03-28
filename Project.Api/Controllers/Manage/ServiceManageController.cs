using Microsoft.AspNetCore.Mvc;
using Project.Application.DTOs.Service;
using Project.Application.Interfaces.Services;


namespace Project.Api.Controllers.Manage;

[ApiController]
[Route("api/manage/service")]
public class ServiceManageController : ControllerBase
{
    private readonly IServiceServices _serviceServices;

    public ServiceManageController(IServiceServices serviceServices)
    {
        _serviceServices = serviceServices;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _serviceServices.GetManageListAsync();
        return Ok(result);
    }


    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _serviceServices.GetManageById(id);
        return Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ServiceCreateRequest request)
    {
        var result = await _serviceServices.CreateAsync(request);
        return Ok(result);
    }


    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] ServiceUpdateRequest request)
    {
        var result = await _serviceServices.UpdateAsync(id, request);
        return Ok(result);
    }


    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _serviceServices.DeleteAsync(id);

        if (!result)
            return NotFound();

        return Ok(new { message = "News deleted successfully" });
    }
}
