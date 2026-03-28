using Microsoft.AspNetCore.Mvc;
using Project.Application.Interfaces.Services;



namespace Project.Api.Controllers.Public;

[ApiController]
[Route("api/public/news")]
public class NewsPublicController : ControllerBase
{
    private readonly INewsService _newsService;

    public NewsPublicController(INewsService newsService)
    {
        _newsService = newsService;
    }


    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        var result = await _newsService.GetManageListAsync();
        return Ok(result);
    }


    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _newsService.GetPublicByIdAsync(id);

        if (result is null)
            return NotFound();

        return Ok(result);
    }



}
