using Microsoft.AspNetCore.Mvc;
using Project.Application.DTOs.News;
using Project.Application.Interfaces.Services;

namespace Project.Api.Controllers.Manage;


[ApiController]
[Route("api/manage/news")]
public class NewsManageController : ControllerBase
{
    private readonly INewsService _newsService;

    public NewsManageController(INewsService newsService)
    {
        _newsService = newsService;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _newsService.GetManageListAsync();
        return Ok(result);
    }


    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _newsService.GetManageByIdAsync(id);

        if (result is null)
            return NotFound();

        return Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] NewsCreateRequest request)
    {
        var result = await _newsService.CreateAsync(request);
        return Ok(result);
    }


    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] NewsUpdateRequest request)
    {
        var result = await _newsService.UpdateAsync(id, request); 
        return Ok(result);
    }


    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _newsService.DeleteAsync(id);

        if (!result)
            return NotFound();

        return Ok(new {message = "News deleted successfully"});
    }
}
