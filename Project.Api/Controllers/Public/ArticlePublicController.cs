using Microsoft.AspNetCore.Mvc;
using Project.Application.Interfaces.Services;


namespace Project.Api.Controllers.Public;

[ApiController]
[Route("api/public/article")]
public class ArticlePublicController : ControllerBase
{
    private readonly IArticleService _articleService;

    public ArticlePublicController(IArticleService articleService)
    {
        _articleService = articleService;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _articleService.GetPublicListAsync();
        return Ok(result);
    }


    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _articleService.GetPublicByIdAsync(id);

        if (result is null)
            return NotFound();

        return Ok(result);
    }
}
