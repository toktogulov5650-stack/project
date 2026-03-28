using System.ComponentModel.DataAnnotations;


namespace Project.Application.DTOs.Article;

public class ArticleCreateRequest
{
    [Required]
    [MaxLength(250)]
    public string Caption { get; set; }

    
    [MaxLength(500)]
    public string Image { get; set; }

    [Required]
    [MaxLength(250)]
    public string Title { get; set; }

    [MaxLength(1000)]
    public string Description { get; set; }

    [MaxLength(2000)]
    public string FullInfo { get; set; }

    [Required]
    public DateTime PublicationDate { get; set; }

    [Required]
    public bool IsPublished { get; set; }
}
