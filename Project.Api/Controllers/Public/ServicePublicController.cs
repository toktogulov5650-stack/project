using Microsoft.AspNetCore.Mvc;
using Project.Application.Interfaces.Services;
using Project.Application.DTOs.Service;


namespace Project.Api.Controllers.Public;

[ApiController]
[Route("api/public/service")]
public class ServicePublicController : ControllerBase
{
    IServiceServices _serviceServices;

    public ServicePublicController(IServiceServices serviceServices)
    {
        _serviceServices = serviceServices;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _serviceServices.GetPublicListAsync();
        return Ok(result);
    }


    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _serviceServices.GetPublicByIdAsync(id);
        return Ok(result);
    }
}
