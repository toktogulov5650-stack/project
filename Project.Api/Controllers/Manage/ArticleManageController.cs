using Microsoft.AspNetCore.Mvc;
using Project.Application.DTOs.Article;
using Project.Application.Interfaces.Services;


namespace Project.Api.Controllers.Manage;

[ApiController]
[Route("api/manage/article")]
public class ArticleManageController : ControllerBase
{
    private readonly IArticleService _articleService;

    public ArticleManageController(IArticleService articleService)
    {
        _articleService = articleService;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _articleService.GetManageListAsync();
        return Ok(result);
    }


    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _articleService.GetManageByIdAsync(id);

        if (result is null)
            return NotFound();

        return Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ArticleCreateRequest request)
    {
        var result = await _articleService.CreateAsync(request);
        return Ok(result);
    }


    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, ArticleUpdateRequest request)
    {
        var result = await _articleService.UpdateAsync(id, request);

        if (result is null)
            return NotFound();

        return Ok(result);
    }


    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _articleService.DeleteAsync(id);

        if (result is false)
            return NotFound();

        return Ok(new { message = "Article deleted successfully" });
    }



}
