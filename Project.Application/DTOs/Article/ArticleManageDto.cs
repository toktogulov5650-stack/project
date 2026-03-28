using System.ComponentModel.DataAnnotations;


namespace Project.Application.DTOs.Article;

public class ArticleManageDto
{
    public int Id { get; set; }
    public string Caption { get; set; } = null!;
    public string Image { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string FullInfo { get; set; } = null!;
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdate { get; set; }
    public DateTime PublicationDate { get; set; }
    public bool IsPublished { get; set; }
}
