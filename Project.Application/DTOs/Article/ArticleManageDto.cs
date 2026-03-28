using System.ComponentModel.DataAnnotations;


namespace Project.Application.DTOs.Article;

public class ArticleManageDto
{
    public int Id { get; set; }
    public string Caption { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string FullInfo { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdate { get; set; }
    public DateTime PublicationDate { get; set; }
    public bool IsPublished { get; set; }
}
